using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FLSGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void GetFls(string flsPath,string csvFile)
        {
            panelWait.Visible = true;
            lblProcess.Visible = true;
            manage_fls fl = new manage_fls(csvFile);
            fl.GenerateCSVFls(csvFile);
            fl.GetFLS(flsPath);
            panelWait.Visible = false;
            lblProcess.Visible = false;
        }

        static string GetDir(string title)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = title;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !StringExtensions.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
                else if(result == DialogResult.Cancel)
                {
                    return null;
                }
                else
                {
                    MessageBox.Show("Error opening file : " + fbd.SelectedPath, "ERROR");
                    return null;
                }
            }
        }

        static string GetFile(string title, string ext, string filter)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = title;
                // ofd.Filter = filter;
                // ofd.DefaultExt = ext;
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && !StringExtensions.IsNullOrWhiteSpace(ofd.FileName))
                {
                    return ofd.FileName;
                }
                else if (result == DialogResult.Cancel)
                {
                    return null;
                }
                else
                {
                    MessageBox.Show("Error opening file : " + ofd.FileName, "ERROR");
                    return null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dirCSV = GetDir("Selct path to CSV output");
            if ( dirCSV == null){
                return;
            }
            string dirBegin = GetDir("Select path to ROOT for FLS to begin");
            if (dirBegin == null)
            {
                return;
            }

            GetFls(dirBegin, dirCSV);
            MessageBox.Show("Finito");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelWait_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
