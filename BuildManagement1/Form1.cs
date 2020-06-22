using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BuildManagement1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sourcePath = @"C:\Users\gamef\Documents\Learning\Practice Build Management Tool\Build Source Location";
        string destinationPath = "";
        bool pathCheck = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = sourcePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // default set for build folder (source)
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "**Please select a source folder/directory**";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // set location for build copy (destination)
            FolderBrowserDialog fbd2 = new FolderBrowserDialog();
            fbd2.RootFolder = Environment.SpecialFolder.Desktop;
            fbd2.Description = "**Please select a directory for build to be copied to.*";

            if (fbd2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fbd2.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Checks to see if source and destination have paths
            bool confirmation = checkPaths();

            if (confirmation)
            {
                MessageBox.Show("Test True");
            }

            // WIP make archive a toggle and archives build by date folder

            // WIP needs to delete old build

            // WIP need progress bar for file copy
        }

        private bool checkPaths()
        {
            
            if (textBox1.Text == "" || textBox1.Text == null || textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Please make sure a both directories have a selected path.");
            }

            else if (textBox1.Text != "" || textBox1.Text != null || textBox2.Text != "" || textBox2.Text != null)
            {
                pathCheck = true;
            }

            return pathCheck;
        }
    }
}
