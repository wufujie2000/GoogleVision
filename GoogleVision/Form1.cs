using Google.Cloud.Vision.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleVision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CREDENTIAL_FILE_JSON = "C:\\Users\\Nuvento\\Downloads\\dotnet-test-lin-58237c722608.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", CREDENTIAL_FILE_JSON);


            var client = ImageAnnotatorClient.Create();
            var image = Google.Cloud.Vision.V1.Image.FromFile("image1.jpg");
            var response = client.DetectLabels(image);
            richTextBox1.Text = "";
            foreach (var annotation in response)
            {
                richTextBox1.Text += annotation.Description+"\r\n";
                
            }

        }
    }
}
