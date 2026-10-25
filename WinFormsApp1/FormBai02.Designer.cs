namespace WinFormsApp1
{
    partial class FormBai02
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
            btnExit = new Button();
            lblFileName = new Label();
            txtFileName = new TextBox();
            lblSize = new Label();
            txtSize = new TextBox();
            lblUrl = new Label();
            txtUrl = new TextBox();
            lblLineCount = new Label();
            txtLineCount = new TextBox();
            lblWordCount = new Label();
            txtWordCount = new TextBox();
            lblCharacterCount = new Label();
            txtCharacterCount = new TextBox();
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
            btnRead.Text = "Read from File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(20, 80);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(61, 15);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "File name";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(120, 77);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(180, 23);
            txtFileName.TabIndex = 2;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(20, 120);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(27, 15);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(120, 117);
            txtSize.Name = "txtSize";
            txtSize.ReadOnly = true;
            txtSize.Size = new Size(180, 23);
            txtSize.TabIndex = 4;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(20, 160);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(28, 15);
            lblUrl.TabIndex = 5;
            lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(120, 157);
            txtUrl.Name = "txtUrl";
            txtUrl.ReadOnly = true;
            txtUrl.Size = new Size(180, 23);
            txtUrl.TabIndex = 6;
            // 
            // lblLineCount
            // 
            lblLineCount.AutoSize = true;
            lblLineCount.Location = new Point(20, 200);
            lblLineCount.Name = "lblLineCount";
            lblLineCount.Size = new Size(63, 15);
            lblLineCount.TabIndex = 7;
            lblLineCount.Text = "Line count";
            // 
            // txtLineCount
            // 
            txtLineCount.Location = new Point(120, 197);
            txtLineCount.Name = "txtLineCount";
            txtLineCount.ReadOnly = true;
            txtLineCount.Size = new Size(180, 23);
            txtLineCount.TabIndex = 8;
            // 
            // lblWordCount
            // 
            lblWordCount.AutoSize = true;
            lblWordCount.Location = new Point(20, 240);
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(74, 15);
            lblWordCount.TabIndex = 9;
            lblWordCount.Text = "Words count";
            // 
            // txtWordCount
            // 
            txtWordCount.Location = new Point(120, 237);
            txtWordCount.Name = "txtWordCount";
            txtWordCount.ReadOnly = true;
            txtWordCount.Size = new Size(180, 23);
            txtWordCount.TabIndex = 10;
            // 
            // lblCharacterCount
            // 
            lblCharacterCount.AutoSize = true;
            lblCharacterCount.Location = new Point(20, 280);
            lblCharacterCount.Name = "lblCharacterCount";
            lblCharacterCount.Size = new Size(91, 15);
            lblCharacterCount.TabIndex = 11;
            lblCharacterCount.Text = "Character count";
            // 
            // txtCharacterCount
            // 
            txtCharacterCount.Location = new Point(120, 277);
            txtCharacterCount.Name = "txtCharacterCount";
            txtCharacterCount.ReadOnly = true;
            txtCharacterCount.Size = new Size(180, 23);
            txtCharacterCount.TabIndex = 12;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LawnGreen;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.Location = new Point(20, 330);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(280, 45);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(320, 20);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(450, 355);
            rtbContent.TabIndex = 14;
            rtbContent.Text = "";
            // 
            // FormBai02
            // 
            ClientSize = new Size(790, 400);
            Controls.Add(rtbContent);
            Controls.Add(btnExit);
            Controls.Add(txtCharacterCount);
            Controls.Add(lblCharacterCount);
            Controls.Add(txtWordCount);
            Controls.Add(lblWordCount);
            Controls.Add(txtLineCount);
            Controls.Add(lblLineCount);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(txtSize);
            Controls.Add(lblSize);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            Controls.Add(btnRead);
            Name = "FormBai02";
            Text = "Bài 02 - Đọc thông tin file .txt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnExit;
        private Label lblFileName;
        private TextBox txtFileName;
        private Label lblSize;
        private TextBox txtSize;
        private Label lblUrl;
        private TextBox txtUrl;
        private Label lblLineCount;
        private TextBox txtLineCount;
        private Label lblWordCount;
        private TextBox txtWordCount;
        private Label lblCharacterCount;
        private TextBox txtCharacterCount;
        private RichTextBox rtbContent;
    }
}