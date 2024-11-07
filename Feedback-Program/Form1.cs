using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Feedback_Program;


namespace Feedback_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox2.Text;
            string directoryPath = "Users";
            string filePath = Path.Combine(directoryPath, $"{userInput}.txt");

            // Check if the directory exists, and create it if it doesn't
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Now write to the file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Write content to the file if needed
                sw.WriteLine("Your content here");
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
