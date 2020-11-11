namespace FLSGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFLS = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PresTXT = new System.Windows.Forms.Label();
            this.lblXbloro = new System.Windows.Forms.Label();
            this.panelWait = new System.Windows.Forms.Panel();
            this.lblProcess = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelWait.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFLS
            // 
            this.btnFLS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFLS.BackColor = System.Drawing.Color.Indigo;
            this.btnFLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFLS.Font = new System.Drawing.Font("Adobe Gothic Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFLS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFLS.Location = new System.Drawing.Point(3, 3);
            this.btnFLS.Name = "btnFLS";
            this.btnFLS.Size = new System.Drawing.Size(300, 145);
            this.btnFLS.TabIndex = 0;
            this.btnFLS.Text = "GetFls";
            this.btnFLS.UseVisualStyleBackColor = false;
            this.btnFLS.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.panelWait);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(759, 459);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PresTXT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblXbloro, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.87719F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.12281F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 456);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // PresTXT
            // 
            this.PresTXT.AutoSize = true;
            this.PresTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PresTXT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PresTXT.Location = new System.Drawing.Point(3, 0);
            this.PresTXT.Name = "PresTXT";
            this.PresTXT.Size = new System.Drawing.Size(290, 117);
            this.PresTXT.TabIndex = 1;
            this.PresTXT.Text = "FLS GUI GENERATOR";
            this.PresTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PresTXT.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblXbloro
            // 
            this.lblXbloro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXbloro.AutoSize = true;
            this.lblXbloro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblXbloro.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXbloro.ForeColor = System.Drawing.Color.White;
            this.lblXbloro.Location = new System.Drawing.Point(53, 270);
            this.lblXbloro.Name = "lblXbloro";
            this.lblXbloro.Size = new System.Drawing.Size(190, 32);
            this.lblXbloro.TabIndex = 2;
            this.lblXbloro.Text = "Made By Xbloro";
            this.lblXbloro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelWait
            // 
            this.panelWait.Controls.Add(this.lblProcess);
            this.panelWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWait.Location = new System.Drawing.Point(0, 0);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(453, 459);
            this.panelWait.TabIndex = 3;
            this.panelWait.Visible = false;
            this.panelWait.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWait_Paint);
            // 
            // lblProcess
            // 
            this.lblProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcess.AutoSize = true;
            this.lblProcess.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProcess.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProcess.Location = new System.Drawing.Point(75, 203);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(305, 26);
            this.lblProcess.TabIndex = 0;
            this.lblProcess.Text = "Processing Please Wait";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnFLS, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(105, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 302);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(759, 459);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelWait.ResumeLayout(false);
            this.panelWait.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFLS;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PresTXT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblXbloro;
    }
}

