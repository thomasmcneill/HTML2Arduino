using System.Windows.Forms;
using System.Text.Json; 


namespace HTML2Arduino
{
    public partial class Form1 : Form
    {
        _Settings settings = new _Settings();
        String settingsFile = Application.LocalUserAppDataPath + "\\HTML2Arduino.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_SourceBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1;  
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Title = "Browse HTML Files";
            openFileDialog1.InitialDirectory = settings.SourcePath;
            openFileDialog1.DefaultExt = "html";
            openFileDialog1.Filter = "html files (*.html)|*.html|js files (*.js)|*.js|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                settings.SourcePath = openFileDialog1.FileName;
                textBox_Source.Text = settings.SourcePath;
                settings.OutputPath = "/" + Path.GetFileName(settings.SourcePath);
                textBox_URL.Text = settings.OutputPath;
            }


        }
       


        public void loadSettings()
        {
            try
            {
                
                string text = System.IO.File.ReadAllText(settingsFile);
                settings = JsonSerializer.Deserialize<_Settings>(text)!;
            }
            catch(Exception ex)
            {
                settings = new _Settings();
                settings.secureClass = "secureServer";
                settings.insecureClass = "insecureServer";
                settings.SourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                settings.OutputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            }
            textBox_insecureServer.Text = settings.insecureClass;
            textBox_secureServer.Text = settings.secureClass;
            textBox_Source.Text = settings.SourcePath;
            textBox_URL.Text = settings.OutputPath;

        }
        public void saveSettings()
        {
            settings.insecureClass = textBox_insecureServer.Text;
            settings.secureClass = textBox_secureServer.Text;
            settings.SourcePath = textBox_Source.Text;
            settings.OutputPath = textBox_URL.Text;

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(settings, options);
            System.IO.File.WriteAllText(settingsFile, jsonString);

           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            String baseName = textBox_Source.Text.Substring(textBox_Source.Text.LastIndexOf("\\")+1);
            baseName = baseName.Substring(0, baseName.IndexOf('.'));

            // Source must exist
            if (!File.Exists(textBox_Source.Text))
            {
                MessageBox.Show("File does not exist");
                return;
            }


            try
            {
                textBox1.Text+=String.Format("/* Created on {0} by HTML2Arduino */\r\n", DateTime.Now.ToString());
                
                textBox1.Text+=String.Format("void register{0}(HTTPServer *{1},HTTPSServer *{2}) {{\r\n", baseName, settings.secureClass, settings.insecureClass);
                textBox1.Text+=String.Format("     ResourceNode* node{0} = new ResourceNode(\"{1}\", \"GET\", &handle{2});\r\n", baseName,settings.OutputPath, baseName);
                textBox1.Text+=String.Format("     {0}->registerNode(node{1});\r\n", settings.secureClass,baseName);
                textBox1.Text+=String.Format("     {0}->registerNode(node{1});\r\n", settings.insecureClass, baseName);
                textBox1.Text+=String.Format("}}\r\n");
                textBox1.Text += String.Format("\r\n");

                textBox1.Text+=String.Format("void handle{0}(HTTPRequest * req, HTTPResponse * res) {{\r\n", baseName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Process Stage: "+ex.Message);
                return;
            }



            try
            {
                foreach (string line in System.IO.File.ReadLines(textBox_Source.Text))
                {
                    String newLine = line.Replace("\"", "\\\"");
                    string outLine = String.Format("    res->println(\"{0}\");\r\n", newLine);
                    textBox1.Text+=outLine;
                    // res->println("

                    
                }
                textBox1.Text+=String.Format("}}\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            textBox1.SelectAll();
            textBox1.Copy();


        }
    }
    public class _Settings
    {
        public string? SourcePath { get; set; }
        public string? OutputPath { get; set; }
        public string? secureClass { get; set; }
        public string? insecureClass { get; set; }

    }
}