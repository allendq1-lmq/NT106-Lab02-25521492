namespace WinFormsApp1
{
    partial class FormBai01
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
            btnRead = new Button();
            btnWrite = new Button();
            rtbContent = new RichTextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(23, 36);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(274, 91);
            btnRead.TabIndex = 0;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.Location = new Point(23, 288);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(274, 91);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(367, 36);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(397, 365);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            // 
            // FormBai01
            // 
            ClientSize = new Size(790, 400);
            Controls.Add(rtbContent);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "FormBai01";
            Text = "Bài 01 - Ghi và Đọc file";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private RichTextBox rtbContent;
    }
}