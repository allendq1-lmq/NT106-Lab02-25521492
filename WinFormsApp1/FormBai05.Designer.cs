namespace WinFormsApp1
{
    partial class FormBai05
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
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblSelectMovie = new Label();
            cboMovie = new ComboBox();
            lblSelectRoom = new Label();
            cboRoom = new ComboBox();
            grpSeats = new GroupBox();
            chkA1 = new CheckBox();
            chkA2 = new CheckBox();
            chkA3 = new CheckBox();
            chkA4 = new CheckBox();
            chkA5 = new CheckBox();
            chkB1 = new CheckBox();
            chkB2 = new CheckBox();
            chkB3 = new CheckBox();
            chkB4 = new CheckBox();
            chkB5 = new CheckBox();
            chkC1 = new CheckBox();
            chkC2 = new CheckBox();
            chkC3 = new CheckBox();
            chkC4 = new CheckBox();
            chkC5 = new CheckBox();
            btnReadFile = new Button();
            btnBuy = new Button();
            btnExportReport = new Button();
            progressBar = new ProgressBar();
            rtbReport = new RichTextBox();
            grpSeats.SuspendLayout();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(20, 20);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(93, 15);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Họ và tên khách:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(130, 17);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // lblSelectMovie
            // 
            lblSelectMovie.AutoSize = true;
            lblSelectMovie.Location = new Point(20, 55);
            lblSelectMovie.Name = "lblSelectMovie";
            lblSelectMovie.Size = new Size(68, 15);
            lblSelectMovie.TabIndex = 2;
            lblSelectMovie.Text = "Chọn phim:";
            // 
            // cboMovie
            // 
            cboMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMovie.FormattingEnabled = true;
            cboMovie.Location = new Point(130, 52);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(200, 23);
            cboMovie.TabIndex = 3;
            cboMovie.SelectedIndexChanged += cboMovie_SelectedIndexChanged;
            // 
            // lblSelectRoom
            // 
            lblSelectRoom.AutoSize = true;
            lblSelectRoom.Location = new Point(20, 90);
            lblSelectRoom.Name = "lblSelectRoom";
            lblSelectRoom.Size = new Size(104, 15);
            lblSelectRoom.TabIndex = 4;
            lblSelectRoom.Text = "Chọn phòng chiếu:";
            // 
            // cboRoom
            // 
            cboRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoom.FormattingEnabled = true;
            cboRoom.Location = new Point(130, 87);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(200, 23);
            cboRoom.TabIndex = 5;
            cboRoom.SelectedIndexChanged += cboRoom_SelectedIndexChanged;
            // 
            // grpSeats
            // 
            grpSeats.Controls.Add(chkC5);
            grpSeats.Controls.Add(chkC4);
            grpSeats.Controls.Add(chkC3);
            grpSeats.Controls.Add(chkC2);
            grpSeats.Controls.Add(chkC1);
            grpSeats.Controls.Add(chkB5);
            grpSeats.Controls.Add(chkB4);
            grpSeats.Controls.Add(chkB3);
            grpSeats.Controls.Add(chkB2);
            grpSeats.Controls.Add(chkB1);
            grpSeats.Controls.Add(chkA5);
            grpSeats.Controls.Add(chkA4);
            grpSeats.Controls.Add(chkA3);
            grpSeats.Controls.Add(chkA2);
            grpSeats.Controls.Add(chkA1);
            grpSeats.Location = new Point(20, 125);
            grpSeats.Name = "grpSeats";
            grpSeats.Size = new Size(310, 140);
            grpSeats.TabIndex = 6;
            grpSeats.TabStop = false;
            grpSeats.Text = "Sơ đồ ghế ngồi";
            // 
            // chkA1
            // 
            chkA1.AutoSize = true;
            chkA1.Location = new Point(20, 30);
            chkA1.Name = "chkA1";
            chkA1.Size = new Size(40, 19);
            chkA1.TabIndex = 0;
            chkA1.Text = "A1";
            chkA1.UseVisualStyleBackColor = true;
            // 
            // chkA2
            // 
            chkA2.AutoSize = true;
            chkA2.Location = new Point(75, 30);
            chkA2.Name = "chkA2";
            chkA2.Size = new Size(40, 19);
            chkA2.TabIndex = 1;
            chkA2.Text = "A2";
            chkA2.UseVisualStyleBackColor = true;
            // 
            // chkA3
            // 
            chkA3.AutoSize = true;
            chkA3.Location = new Point(130, 30);
            chkA3.Name = "chkA3";
            chkA3.Size = new Size(40, 19);
            chkA3.TabIndex = 2;
            chkA3.Text = "A3";
            chkA3.UseVisualStyleBackColor = true;
            // 
            // chkA4
            // 
            chkA4.AutoSize = true;
            chkA4.Location = new Point(185, 30);
            chkA4.Name = "chkA4";
            chkA4.Size = new Size(40, 19);
            chkA4.TabIndex = 3;
            chkA4.Text = "A4";
            chkA4.UseVisualStyleBackColor = true;
            // 
            // chkA5
            // 
            chkA5.AutoSize = true;
            chkA5.Location = new Point(240, 30);
            chkA5.Name = "chkA5";
            chkA5.Size = new Size(40, 19);
            chkA5.TabIndex = 4;
            chkA5.Text = "A5";
            chkA5.UseVisualStyleBackColor = true;
            // 
            // chkB1
            // 
            chkB1.AutoSize = true;
            chkB1.Location = new Point(20, 65);
            chkB1.Name = "chkB1";
            chkB1.Size = new Size(39, 19);
            chkB1.TabIndex = 5;
            chkB1.Text = "B1";
            chkB1.UseVisualStyleBackColor = true;
            // 
            // chkB2
            // 
            chkB2.AutoSize = true;
            chkB2.Location = new Point(75, 65);
            chkB2.Name = "chkB2";
            chkB2.Size = new Size(39, 19);
            chkB2.TabIndex = 6;
            chkB2.Text = "B2";
            chkB2.UseVisualStyleBackColor = true;
            // 
            // chkB3
            // 
            chkB3.AutoSize = true;
            chkB3.Location = new Point(130, 65);
            chkB3.Name = "chkB3";
            chkB3.Size = new Size(39, 19);
            chkB3.TabIndex = 7;
            chkB3.Text = "B3";
            chkB3.UseVisualStyleBackColor = true;
            // 
            // chkB4
            // 
            chkB4.AutoSize = true;
            chkB4.Location = new Point(185, 65);
            chkB4.Name = "chkB4";
            chkB4.Size = new Size(39, 19);
            chkB4.TabIndex = 8;
            chkB4.Text = "B4";
            chkB4.UseVisualStyleBackColor = true;
            // 
            // chkB5
            // 
            chkB5.AutoSize = true;
            chkB5.Location = new Point(240, 65);
            chkB5.Name = "chkB5";
            chkB5.Size = new Size(39, 19);
            chkB5.TabIndex = 9;
            chkB5.Text = "B5";
            chkB5.UseVisualStyleBackColor = true;
            // 
            // chkC1
            // 
            chkC1.AutoSize = true;
            chkC1.Location = new Point(20, 100);
            chkC1.Name = "chkC1";
            chkC1.Size = new Size(40, 19);
            chkC1.TabIndex = 10;
            chkC1.Text = "C1";
            chkC1.UseVisualStyleBackColor = true;
            // 
            // chkC2
            // 
            chkC2.AutoSize = true;
            chkC2.Location = new Point(75, 100);
            chkC2.Name = "chkC2";
            chkC2.Size = new Size(40, 19);
            chkC2.TabIndex = 11;
            chkC2.Text = "C2";
            chkC2.UseVisualStyleBackColor = true;
            // 
            // chkC3
            // 
            chkC3.AutoSize = true;
            chkC3.Location = new Point(130, 100);
            chkC3.Name = "chkC3";
            chkC3.Size = new Size(40, 19);
            chkC3.TabIndex = 12;
            chkC3.Text = "C3";
            chkC3.UseVisualStyleBackColor = true;
            // 
            // chkC4
            // 
            chkC4.AutoSize = true;
            chkC4.Location = new Point(185, 100);
            chkC4.Name = "chkC4";
            chkC4.Size = new Size(40, 19);
            chkC4.TabIndex = 13;
            chkC4.Text = "C4";
            chkC4.UseVisualStyleBackColor = true;
            // 
            // chkC5
            // 
            chkC5.AutoSize = true;
            chkC5.Location = new Point(240, 100);
            chkC5.Name = "chkC5";
            chkC5.Size = new Size(40, 19);
            chkC5.TabIndex = 14;
            chkC5.Text = "C5";
            chkC5.UseVisualStyleBackColor = true;
            // 
            // btnReadFile
            // 
            btnReadFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReadFile.Location = new Point(20, 280);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(95, 35);
            btnReadFile.TabIndex = 7;
            btnReadFile.Text = "ĐỌC PHIM";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuy.Location = new Point(125, 280);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(95, 35);
            btnBuy.TabIndex = 8;
            btnBuy.Text = "MUA VÉ";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnExportReport
            // 
            btnExportReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportReport.Location = new Point(230, 280);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(100, 35);
            btnExportReport.TabIndex = 9;
            btnExportReport.Text = "XUẤT BÁO CÁO";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 330);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(310, 23);
            progressBar.TabIndex = 10;
            // 
            // rtbReport
            // 
            rtbReport.Location = new Point(350, 17);
            rtbReport.Name = "rtbReport";
            rtbReport.ReadOnly = true;
            rtbReport.Size = new Size(410, 336);
            rtbReport.TabIndex = 11;
            rtbReport.Text = "";
            // 
            // FormBai05
            // 
            ClientSize = new Size(780, 375);
            Controls.Add(rtbReport);
            Controls.Add(progressBar);
            Controls.Add(btnExportReport);
            Controls.Add(btnBuy);
            Controls.Add(btnReadFile);
            Controls.Add(grpSeats);
            Controls.Add(cboRoom);
            Controls.Add(lblSelectRoom);
            Controls.Add(cboMovie);
            Controls.Add(lblSelectMovie);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Name = "FormBai05";
            Text = "Bài 05 - Quản lý phòng vé (phiên bản 2)";
            grpSeats.ResumeLayout(false);
            grpSeats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblSelectMovie;
        private ComboBox cboMovie;
        private Label lblSelectRoom;
        private ComboBox cboRoom;
        private GroupBox grpSeats;
        private CheckBox chkA1;
        private CheckBox chkA2;
        private CheckBox chkA3;
        private CheckBox chkA4;
        private CheckBox chkA5;
        private CheckBox chkB1;
        private CheckBox chkB2;
        private CheckBox chkB3;
        private CheckBox chkB4;
        private CheckBox chkB5;
        private CheckBox chkC1;
        private CheckBox chkC2;
        private CheckBox chkC3;
        private CheckBox chkC4;
        private CheckBox chkC5;
        private Button btnReadFile;
        private Button btnBuy;
        private Button btnExportReport;
        private ProgressBar progressBar;
        private RichTextBox rtbReport;
    }
}