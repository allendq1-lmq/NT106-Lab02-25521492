using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WinFormsApp1
{
    public partial class FormBai06 : Form
    {
        private readonly string connectionString = "Data Source=food.db";
        private readonly List<FoodItem> foodList = new List<FoodItem>();

        public FormBai06()
        {
            SQLitePCL.Batteries.Init();
            InitializeComponent();
            InitializeDatabase();
            LoadFoodData();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS NguoiDung (
                        IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                        HoVaTen TEXT NOT NULL,
                        QuyenHan TEXT
                    );

                    CREATE TABLE IF NOT EXISTS MonAn (
                        IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                        TenMonAn TEXT NOT NULL,
                        HinhAnh TEXT,
                        IDNCC INTEGER,
                        FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                    );
                ";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT COUNT(*) FROM NguoiDung;";
                long userCount = (long)(command.ExecuteScalar() ?? 0);
                if (userCount == 0)
                {
                    command.CommandText = @"
                        INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES 
                        ('Nguyễn Văn A', 'User'),
                        ('Trần Thị B', 'Admin'),
                        ('Lê Minh C', 'User');
                    ";
                    command.ExecuteNonQuery();
                }

                command.CommandText = "SELECT COUNT(*) FROM MonAn;";
                long foodCount = (long)(command.ExecuteScalar() ?? 0);
                if (foodCount == 0)
                {
                    command.CommandText = @"
                        INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES 
                        ('Bún riêu', 'bunrieu.jpg', 1),
                        ('Bún thịt nướng', 'bunthitnuong.jpg', 2),
                        ('Cơm tấm sườn trứng', 'comtam.jpg', 1),
                        ('Phở bò', 'phobo.jpg', 3),
                        ('Gỏi cuốn', 'goicuon.jpg', 2);
                    ";
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadFoodData()
        {
            foodList.Clear();
            lsvFood.Items.Clear();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT m.IDMA, m.TenMonAn, m.HinhAnh, m.IDNCC, u.HoVaTen 
                    FROM MonAn m 
                    LEFT JOIN NguoiDung u ON m.IDNCC = u.IDNCC;
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FoodItem item = new FoodItem
                        {
                            IDMA = reader.GetInt32(0),
                            TenMonAn = reader.GetString(1),
                            HinhAnh = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                            IDNCC = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                            ContributorName = reader.IsDBNull(4) ? "Không xác định" : reader.GetString(4)
                        };

                        foodList.Add(item);

                        ListViewItem lsvItem = new ListViewItem(item.IDMA.ToString());
                        lsvItem.SubItems.Add(item.TenMonAn);
                        lsvItem.SubItems.Add(item.ContributorName);
                        lsvItem.Tag = item;

                        lsvFood.Items.Add(lsvItem);
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadFoodData();
            MessageBox.Show("Đã tải lại danh sách món ăn từ SQLite thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (foodList.Count == 0) return;

            Random random = new Random();
            int index = random.Next(0, foodList.Count);
            FoodItem selectedFood = foodList[index];

            DisplayFoodDetails(selectedFood);
        }

        private void lsvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvFood.SelectedItems.Count > 0)
            {
                if (lsvFood.SelectedItems[0].Tag is FoodItem selectedFood)
                {
                    DisplayFoodDetails(selectedFood);
                }
            }
        }


        private void DisplayFoodDetails(FoodItem food)
        {
            txtResultDish.Text = food.TenMonAn;
            txtResultContributor.Text = food.ContributorName;

            if (picFood.Image != null)
            {
                var oldImg = picFood.Image;
                picFood.Image = null;
                oldImg.Dispose();
            }

            if (!string.IsNullOrWhiteSpace(food.HinhAnh))
            {
                try
                {
                    string imagePath = food.HinhAnh;

                    if (!Path.IsPathRooted(imagePath))
                    {
                        imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
                    }

                    if (File.Exists(imagePath))
                    {
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        using (Image temp = Image.FromStream(fs))
                        {
                            picFood.Image = new Bitmap(temp);
                        }
                    }
                    else
                    {
                        picFood.Image = null;
                    }
                }
                catch
                {
                    picFood.Image = null;
                }
            }
        }
    }

    public class FoodItem
    {
        public int IDMA { get; set; }
        public string TenMonAn { get; set; } = string.Empty;
        public string HinhAnh { get; set; } = string.Empty;
        public int IDNCC { get; set; }
        public string ContributorName { get; set; } = string.Empty;
    }
}