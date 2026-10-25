namespace WinFormsApp1
{
    partial class FormBai03
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
            btnRead.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRead.Location = new Point(20, 20);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(280, 45);
            btnRead.TabIndex = 0;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnWrite.Location = new Point(20, 80);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(280, 45);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "TÍNH VÀ GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(320, 20);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(450, 355);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // FormBai03
            // 
            ClientSize = new Size(790, 400);
            Controls.Add(rtbContent);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "FormBai03";
            Text = "Bài 03 - Đọc và Ghi file tính toán biểu thức";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private RichTextBox rtbContent;
    }
}