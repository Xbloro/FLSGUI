﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace FLSGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async Task GetFlsAsync (string flsPath,string csvFile)
        {
            
            panelWait.Visible = true;
            lblProcess.Visible = true;
            
            await Task.Run(() =>
            {
                manage_fls fl = new manage_fls(csvFile);
                fl.GenerateCSVFls(csvFile);
                fl.GetFLS(flsPath);
            });
        }
       public static  void GetFls(string flsPath, string csvFile)
        {   

            manage_fls fl = new manage_fls(csvFile);
            fl.GenerateCSVFls(csvFile);
            fl.GetFLS(flsPath);
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

        private  void button1_Click(object sender, EventArgs e)
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

            panelWait.Visible = true;
            lblProcess.Visible = true;
            btnFLS.Enabled = false;
            //var t = Task.Run(async () => { GetFlsAsync(dirBegin, dirCSV);  });}

            Thread t = new Thread(() =>
            {
                GetFls(dirBegin, dirCSV);
                Action ShowWait = () => panelWait.Visible = false;
                Action ShowLblWait = () => lblProcess.Visible = false;
                Action showEnd = () => MessageBox.Show("Finito");
                Action setActiveBtn = () => btnFLS.Enabled = true;
                this.BeginInvoke(ShowWait);
                this.BeginInvoke(ShowLblWait);
                this.BeginInvoke(showEnd);
                this.BeginInvoke(setActiveBtn);
            });

            t.Start();
            
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
