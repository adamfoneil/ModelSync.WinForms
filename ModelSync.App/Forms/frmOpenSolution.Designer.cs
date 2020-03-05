﻿namespace ModelSync.App.Forms
{
    partial class frmOpenSolution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenSolution));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSolution = new System.Windows.Forms.ComboBox();
            this.llSolutionFolder = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblSolutionCount = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ddbRecent = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(397, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(316, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Solution:";
            // 
            // cbSolution
            // 
            this.cbSolution.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSolution.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSolution.FormattingEnabled = true;
            this.cbSolution.Location = new System.Drawing.Point(12, 33);
            this.cbSolution.Name = "cbSolution";
            this.cbSolution.Size = new System.Drawing.Size(459, 21);
            this.cbSolution.TabIndex = 1;
            // 
            // llSolutionFolder
            // 
            this.llSolutionFolder.AutoSize = true;
            this.llSolutionFolder.Location = new System.Drawing.Point(13, 163);
            this.llSolutionFolder.Name = "llSolutionFolder";
            this.llSolutionFolder.Size = new System.Drawing.Size(97, 13);
            this.llSolutionFolder.TabIndex = 3;
            this.llSolutionFolder.TabStop = true;
            this.llSolutionFolder.Text = "Solution Folder:";
            this.llSolutionFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSolutionFolder_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solution Folder:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 15);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // lblSolutionCount
            // 
            this.lblSolutionCount.Location = new System.Drawing.Point(349, 63);
            this.lblSolutionCount.Name = "lblSolutionCount";
            this.lblSolutionCount.Size = new System.Drawing.Size(122, 15);
            this.lblSolutionCount.TabIndex = 7;
            this.lblSolutionCount.Text = "0 solutions found";
            this.lblSolutionCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbRecent});
            this.toolStrip1.Location = new System.Drawing.Point(15, 90);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(90, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ddbRecent
            // 
            this.ddbRecent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbRecent.Image = ((System.Drawing.Image)(resources.GetObject("ddbRecent.Image")));
            this.ddbRecent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbRecent.Name = "ddbRecent";
            this.ddbRecent.Size = new System.Drawing.Size(56, 22);
            this.ddbRecent.Text = "Recent";
            // 
            // frmOpenSolution
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(483, 193);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblSolutionCount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llSolutionFolder);
            this.Controls.Add(this.cbSolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpenSolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Solution";
            this.Load += new System.EventHandler(this.frmOpenSolution_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSolution;
        private System.Windows.Forms.LinkLabel llSolutionFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblSolutionCount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ddbRecent;
    }
}