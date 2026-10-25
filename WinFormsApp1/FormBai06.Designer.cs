namespace WinFormsApp1
{
    partial class FormBai06
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
            lsvFood = new ListView();
            colId = new ColumnHeader();
            colFoodName = new ColumnHeader();
            colContributor = new ColumnHeader();
            btnLoadData = new Button();
            btnRandom = new Button();
            picFood = new PictureBox();
            lblResultDish = new Label();
            txtResultDish = new TextBox();
            lblResultContributor = new Label();
            txtResultContributor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picFood).BeginInit();
            SuspendLayout();

            lsvFood.Columns.AddRange(new ColumnHeader[] { colId, colFoodName, colContributor });
            lsvFood.FullRowSelect = true;
            lsvFood.GridLines = true;
            lsvFood.Location = new Point(20, 20);
            lsvFood.Name = "lsvFood";
            lsvFood.Size = new Size(380, 360);
            lsvFood.TabIndex = 0;
            lsvFood.UseCompatibleStateImageBehavior = false;
            lsvFood.View = View.Details;
            lsvFood.SelectedIndexChanged += lsvFood_SelectedIndexChanged;

            colId.Text = "ID";
            colId.Width = 50;

            colFoodName.Text = "Tên món ăn";
            colFoodName.Width = 180;

            colContributor.Text = "Người đóng góp";
            colContributor.Width = 140;

            btnLoadData.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLoadData.Location = new Point(420, 20);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(340, 35);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "TẢI DANH SÁCH MÓN ĂN (SQLITE)";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;

            btnRandom.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRandom.Location = new Point(420, 65);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(340, 45);
            btnRandom.TabIndex = 2;
            btnRandom.Text = "HÔM NAY ĂN GÌ?";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;

            picFood.BorderStyle = BorderStyle.FixedSingle;
            picFood.Location = new Point(420, 120);
            picFood.Name = "picFood";
            picFood.Size = new Size(340, 180);
            picFood.SizeMode = PictureBoxSizeMode.Zoom;
            picFood.TabIndex = 3;
            picFood.TabStop = false;

            lblResultDish.AutoSize = true;
            lblResultDish.Location = new Point(420, 315);
            lblResultDish.Name = "lblResultDish";
            lblResultDish.Size = new Size(76, 15);
            lblResultDish.TabIndex = 4;
            lblResultDish.Text = "Món ăn chọn:";

            txtResultDish.Location = new Point(520, 312);
            txtResultDish.Name = "txtResultDish";
            txtResultDish.ReadOnly = true;
            txtResultDish.Size = new Size(240, 23);
            txtResultDish.TabIndex = 5;

            lblResultContributor.AutoSize = true;
            lblResultContributor.Location = new Point(420, 355);
            lblResultContributor.Name = "lblResultContributor";
            lblResultContributor.Size = new Size(96, 15);
            lblResultContributor.TabIndex = 6;
            lblResultContributor.Text = "Người đóng góp:";

            txtResultContributor.Location = new Point(520, 352);
            txtResultContributor.Name = "txtResultContributor";
            txtResultContributor.ReadOnly = true;
            txtResultContributor.Size = new Size(240, 23);
            txtResultContributor.TabIndex = 7;

            ClientSize = new Size(780, 400);
            Controls.Add(txtResultContributor);
            Controls.Add(lblResultContributor);
            Controls.Add(txtResultDish);
            Controls.Add(lblResultDish);
            Controls.Add(picFood);
            Controls.Add(btnRandom);
            Controls.Add(btnLoadData);
            Controls.Add(lsvFood);
            Name = "FormBai06";
            Text = "Bài 06 - Hôm nay ăn gì? (SQLite)";
            ((System.ComponentModel.ISupportInitialize)picFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvFood;
        private ColumnHeader colId;
        private ColumnHeader colFoodName;
        private ColumnHeader colContributor;
        private Button btnLoadData;
        private Button btnRandom;
        private PictureBox picFood;
        private Label lblResultDish;
        private TextBox txtResultDish;
        private Label lblResultContributor;
        private TextBox txtResultContributor;
    }
}