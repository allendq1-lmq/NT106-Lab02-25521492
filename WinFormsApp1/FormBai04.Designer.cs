namespace WinFormsApp1
{
    partial class FormBai04
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
            btnWriteFile = new Button();
            btnAdd = new Button();
            lblInputName = new Label();
            lblInputId = new Label();
            lblInputPhone = new Label();
            lblInputCourse1 = new Label();
            lblInputCourse2 = new Label();
            lblInputCourse3 = new Label();
            lblInputAverage = new Label();
            txtInputName = new TextBox();
            txtInputId = new TextBox();
            txtInputPhone = new TextBox();
            txtInputCourse1 = new TextBox();
            txtInputCourse2 = new TextBox();
            txtInputCourse3 = new TextBox();
            txtInputAverage = new TextBox();
            rtbDisplay = new RichTextBox();
            btnReadFile = new Button();
            lblOutputName = new Label();
            lblOutputId = new Label();
            lblOutputPhone = new Label();
            lblOutputCourse1 = new Label();
            lblOutputCourse2 = new Label();
            lblOutputCourse3 = new Label();
            lblOutputAverage = new Label();
            txtOutputName = new TextBox();
            txtOutputId = new TextBox();
            txtOutputPhone = new TextBox();
            txtOutputCourse1 = new TextBox();
            txtOutputCourse2 = new TextBox();
            txtOutputCourse3 = new TextBox();
            txtOutputAverage = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            lblPageIndex = new Label();
            SuspendLayout();
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(30, 20);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(220, 35);
            btnWriteFile.TabIndex = 0;
            btnWriteFile.Text = "Write to a File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // txtInputName
            // 
            txtInputName.Location = new Point(30, 75);
            txtInputName.Name = "txtInputName";
            txtInputName.Size = new Size(150, 23);
            txtInputName.TabIndex = 1;
            // 
            // lblInputName
            // 
            lblInputName.AutoSize = true;
            lblInputName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputName.Location = new Point(200, 78);
            lblInputName.Name = "lblInputName";
            lblInputName.Size = new Size(40, 15);
            lblInputName.TabIndex = 2;
            lblInputName.Text = "Name";
            // 
            // txtInputId
            // 
            txtInputId.Location = new Point(30, 120);
            txtInputId.Name = "txtInputId";
            txtInputId.Size = new Size(150, 23);
            txtInputId.TabIndex = 3;
            // 
            // lblInputId
            // 
            lblInputId.AutoSize = true;
            lblInputId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputId.Location = new Point(220, 123);
            lblInputId.Name = "lblInputId";
            lblInputId.Size = new Size(20, 15);
            lblInputId.TabIndex = 4;
            lblInputId.Text = "ID";
            // 
            // txtInputPhone
            // 
            txtInputPhone.Location = new Point(30, 165);
            txtInputPhone.Name = "txtInputPhone";
            txtInputPhone.Size = new Size(150, 23);
            txtInputPhone.TabIndex = 5;
            // 
            // lblInputPhone
            // 
            lblInputPhone.AutoSize = true;
            lblInputPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputPhone.Location = new Point(198, 168);
            lblInputPhone.Name = "lblInputPhone";
            lblInputPhone.Size = new Size(42, 15);
            lblInputPhone.TabIndex = 6;
            lblInputPhone.Text = "Phone";
            // 
            // txtInputCourse1
            // 
            txtInputCourse1.Location = new Point(30, 210);
            txtInputCourse1.Name = "txtInputCourse1";
            txtInputCourse1.Size = new Size(150, 23);
            txtInputCourse1.TabIndex = 7;
            // 
            // lblInputCourse1
            // 
            lblInputCourse1.AutoSize = true;
            lblInputCourse1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputCourse1.Location = new Point(184, 213);
            lblInputCourse1.Name = "lblInputCourse1";
            lblInputCourse1.Size = new Size(56, 15);
            lblInputCourse1.TabIndex = 8;
            lblInputCourse1.Text = "Course 1";
            // 
            // txtInputCourse2
            // 
            txtInputCourse2.Location = new Point(30, 255);
            txtInputCourse2.Name = "txtInputCourse2";
            txtInputCourse2.Size = new Size(150, 23);
            txtInputCourse2.TabIndex = 9;
            // 
            // lblInputCourse2
            // 
            lblInputCourse2.AutoSize = true;
            lblInputCourse2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputCourse2.Location = new Point(184, 258);
            lblInputCourse2.Name = "lblInputCourse2";
            lblInputCourse2.Size = new Size(56, 15);
            lblInputCourse2.TabIndex = 10;
            lblInputCourse2.Text = "Course 2";
            // 
            // txtInputCourse3
            // 
            txtInputCourse3.Location = new Point(30, 300);
            txtInputCourse3.Name = "txtInputCourse3";
            txtInputCourse3.Size = new Size(150, 23);
            txtInputCourse3.TabIndex = 11;
            // 
            // lblInputCourse3
            // 
            lblInputCourse3.AutoSize = true;
            lblInputCourse3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputCourse3.Location = new Point(184, 303);
            lblInputCourse3.Name = "lblInputCourse3";
            lblInputCourse3.Size = new Size(56, 15);
            lblInputCourse3.TabIndex = 12;
            lblInputCourse3.Text = "Course 3";
            // 
            // txtInputAverage
            // 
            txtInputAverage.Location = new Point(30, 345);
            txtInputAverage.Name = "txtInputAverage";
            txtInputAverage.ReadOnly = true;
            txtInputAverage.Size = new Size(150, 23);
            txtInputAverage.TabIndex = 13;
            // 
            // lblInputAverage
            // 
            lblInputAverage.AutoSize = true;
            lblInputAverage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputAverage.Location = new Point(187, 348);
            lblInputAverage.Name = "lblInputAverage";
            lblInputAverage.Size = new Size(53, 15);
            lblInputAverage.TabIndex = 14;
            lblInputAverage.Text = "Average";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(80, 390);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rtbDisplay
            // 
            rtbDisplay.Location = new Point(270, 20);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.ReadOnly = true;
            rtbDisplay.Size = new Size(220, 400);
            rtbDisplay.TabIndex = 16;
            rtbDisplay.Text = "";
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(510, 20);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(220, 35);
            btnReadFile.TabIndex = 17;
            btnReadFile.Text = "Button to read a File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // txtOutputName
            // 
            txtOutputName.Location = new Point(510, 75);
            txtOutputName.Name = "txtOutputName";
            txtOutputName.ReadOnly = true;
            txtOutputName.Size = new Size(150, 23);
            txtOutputName.TabIndex = 18;
            // 
            // lblOutputName
            // 
            lblOutputName.AutoSize = true;
            lblOutputName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOutputName.Location = new Point(680, 78);
            lblOutputName.Name = "lblOutputName";
            lblOutputName.Size = new Size(40, 15);
            lblOutputName.TabIndex = 19;
            lblOutputName.Text = "Name";
            // 
            // txtOutputId
            // 
            txtOutputId.Location = new Point(510, 120);
            txtOutputId.Name = "txtOutputId";
            txtOutputId.ReadOnly = true;
            txtOutputId.Size = new Size(150, 23);
            txtOutputId.TabIndex = 20;
            // 
            // lblOutputId
            // 
            lblOutputId.AutoSize = true;
            lblOutputId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOutputId.Location = new Point(700, 123);
            lblOutputId.Name = "lblOutputId";
            lblOutputId.Size = new Size(20, 15);
            lblOutputId.TabIndex = 21;
            lblOutputId.Text = "ID";
            // 
            // txtOutputPhone
            // 
            txtOutputPhone.Location = new Point(510, 165);
            txtOutputPhone.Name = "txtOutputPhone";
            txtOutputPhone.ReadOnly = true;
            txtOutputPhone.Size = new Size(150, 23);
            txtOutputPhone.TabIndex = 22;
            // 
            // lblOutputPhone
            // 
            lblOutputPhone.AutoSize = true;
            lblOutputPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOutputPhone.Location = new Point(678, 168);
            lblOutputPhone.Name = "lblOutputPhone";
            lblOutputPhone.Size = new Size(42, 15);
            lblOutputPhone.TabIndex = 23;
            lblOutputPhone.Text = "Phone";
            // 
            // txtOutputCourse1
            // 
            txtOutputCourse1.Location = new Point(510, 210);
            txtOutputCourse1.Name = "txtOutputCourse1";
            txtOutputCourse1.ReadOnly = true;
            txtOutputCourse1.Size = new Size(150, 23);
            txtOutputCourse1.TabIndex = 24;
            // 
            // lblOutputCourse1
            // 
            lblOutputCourse1.AutoSize = true;
            lblOutputCourse1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOutputCourse1.Location = new Point(664, 213);
            lblOutputCourse1.Name = "lblOutputCourse1";
            lblOutputCourse1.Size = new Size(56, 15);
            lblOutputCourse1.TabIndex = 25;
            lblOutputCourse1.Text = "Course 1";
            // 
            // txtOutputCourse2
            // 
            txtOutputCourse2.Location = new Point(510, 255);
            txtOutputCourse2.Name = "txtOutputCourse2";
            txtOutputCourse2.ReadOnly = true;
            txtOutputCourse2.Size = new Size(150, 23);
            txtOutputCourse2.TabIndex = 26;
            // 
            // lblOutputCourse2
            // 
            lblOutputCourse2.AutoSize = true;
            lblOutputCourse2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOutputCourse2.Location = new Point(664, 258);
            lblOutputCourse2.Name = "lblOutputCourse2";
            lblOutputCourse2.Size = new Size(56, 15);
            lblOutputCourse2.TabIndex = 27;
            lblOutputCourse2.Text = "Course 2";
            // 
            // txtOutputCourse3
            // 
            txtOutputCourse3.Location = new Point(510, 300);
            txtOutputCourse3.Name = "txtOutputCourse3";
            txtOutputCourse3.ReadOnly = true;
            txtOutputCourse3.Size = new Size(150, 23);
            txtOutputCourse3.TabIndex = 28;
            // 
            // lblOutputCourse3
            // 
            lblOutputCourse3.AutoSize = true;
            lblOutputCourse3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOutputCourse3.Location = new Point(664, 303);
            lblOutputCourse3.Name = "lblOutputCourse3";
            lblOutputCourse3.Size = new Size(56, 15);
            lblOutputCourse3.TabIndex = 29;
            lblOutputCourse3.Text = "Course 3";
            // 
            // txtOutputAverage
            // 
            txtOutputAverage.Location = new Point(510, 345);
            txtOutputAverage.Name = "txtOutputAverage";
            txtOutputAverage.ReadOnly = true;
            txtOutputAverage.Size = new Size(150, 23);
            txtOutputAverage.TabIndex = 30;
            // 
            // lblOutputAverage
            // 
            lblOutputAverage.AutoSize = true;
            lblOutputAverage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOutputAverage.Location = new Point(667, 348);
            lblOutputAverage.Name = "lblOutputAverage";
            lblOutputAverage.Size = new Size(53, 15);
            lblOutputAverage.TabIndex = 31;
            lblOutputAverage.Text = "Average";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(510, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(60, 30);
            btnBack.TabIndex = 32;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblPageIndex
            // 
            lblPageIndex.AutoSize = true;
            lblPageIndex.Location = new Point(610, 398);
            lblPageIndex.Name = "lblPageIndex";
            lblPageIndex.Size = new Size(13, 15);
            lblPageIndex.TabIndex = 33;
            lblPageIndex.Text = "1";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(670, 390);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(60, 30);
            btnNext.TabIndex = 34;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FormBai04
            // 
            ClientSize = new Size(760, 440);
            Controls.Add(btnNext);
            Controls.Add(lblPageIndex);
            Controls.Add(btnBack);
            Controls.Add(lblOutputAverage);
            Controls.Add(txtOutputAverage);
            Controls.Add(lblOutputCourse3);
            Controls.Add(txtOutputCourse3);
            Controls.Add(lblOutputCourse2);
            Controls.Add(txtOutputCourse2);
            Controls.Add(lblOutputCourse1);
            Controls.Add(txtOutputCourse1);
            Controls.Add(lblOutputPhone);
            Controls.Add(txtOutputPhone);
            Controls.Add(lblOutputId);
            Controls.Add(txtOutputId);
            Controls.Add(lblOutputName);
            Controls.Add(txtOutputName);
            Controls.Add(btnReadFile);
            Controls.Add(rtbDisplay);
            Controls.Add(btnAdd);
            Controls.Add(lblInputAverage);
            Controls.Add(txtInputAverage);
            Controls.Add(lblInputCourse3);
            Controls.Add(txtInputCourse3);
            Controls.Add(lblInputCourse2);
            Controls.Add(txtInputCourse2);
            Controls.Add(lblInputCourse1);
            Controls.Add(txtInputCourse1);
            Controls.Add(lblInputPhone);
            Controls.Add(txtInputPhone);
            Controls.Add(lblInputId);
            Controls.Add(txtInputId);
            Controls.Add(lblInputName);
            Controls.Add(txtInputName);
            Controls.Add(btnWriteFile);
            Name = "FormBai04";
            Text = "Bài 04 - Quản lý Sinh viên (Lưu/Đọc file)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWriteFile;
        private Button btnAdd;
        private Label lblInputName;
        private Label lblInputId;
        private Label lblInputPhone;
        private Label lblInputCourse1;
        private Label lblInputCourse2;
        private Label lblInputCourse3;
        private Label lblInputAverage;
        private TextBox txtInputName;
        private TextBox txtInputId;
        private TextBox txtInputPhone;
        private TextBox txtInputCourse1;
        private TextBox txtInputCourse2;
        private TextBox txtInputCourse3;
        private TextBox txtInputAverage;
        private RichTextBox rtbDisplay;
        private Button btnReadFile;
        private Label lblOutputName;
        private Label lblOutputId;
        private Label lblOutputPhone;
        private Label lblOutputCourse1;
        private Label lblOutputCourse2;
        private Label lblOutputCourse3;
        private Label lblOutputAverage;
        private TextBox txtOutputName;
        private TextBox txtOutputId;
        private TextBox txtOutputPhone;
        private TextBox txtOutputCourse1;
        private TextBox txtOutputCourse2;
        private TextBox txtOutputCourse3;
        private TextBox txtOutputAverage;
        private Button btnBack;
        private Button btnNext;
        private Label lblPageIndex;
    }
}