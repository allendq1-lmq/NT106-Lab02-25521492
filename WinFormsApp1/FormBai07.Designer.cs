using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    partial class FormBai07
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tvDirectory = new System.Windows.Forms.TreeView();
            lblFileContent = new System.Windows.Forms.Label();
            rtbContent = new System.Windows.Forms.RichTextBox();
            picContent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)picContent).BeginInit();
            SuspendLayout();

            tvDirectory.Location = new System.Drawing.Point(20, 20);
            tvDirectory.Name = "tvDirectory";
            tvDirectory.Size = new System.Drawing.Size(280, 420);
            tvDirectory.TabIndex = 0;
            tvDirectory.BeforeExpand += tvDirectory_BeforeExpand;
            tvDirectory.AfterSelect += tvDirectory_AfterSelect;

            lblFileContent.AutoSize = true;
            lblFileContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblFileContent.Location = new System.Drawing.Point(320, 20);
            lblFileContent.Name = "lblFileContent";
            lblFileContent.Size = new System.Drawing.Size(88, 19);
            lblFileContent.TabIndex = 1;
            lblFileContent.Text = "File Content";

            rtbContent.Location = new System.Drawing.Point(320, 50);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new System.Drawing.Size(440, 390);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";

            picContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picContent.Location = new System.Drawing.Point(320, 50);
            picContent.Name = "picContent";
            picContent.Size = new System.Drawing.Size(440, 390);
            picContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picContent.TabIndex = 3;
            picContent.TabStop = false;
            picContent.Visible = false;

            ClientSize = new System.Drawing.Size(780, 460);
            Controls.Add(picContent);
            Controls.Add(rtbContent);
            Controls.Add(lblFileContent);
            Controls.Add(tvDirectory);
            Name = "FormBai07";
            Text = "Bài 07 - Duyệt thư mục";
            Load += FormBai07_Load;
            ((System.ComponentModel.ISupportInitialize)picContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView tvDirectory;
        private System.Windows.Forms.Label lblFileContent;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.PictureBox picContent;
    }
}