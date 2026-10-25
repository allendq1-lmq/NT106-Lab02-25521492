using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormBai05 : Form
    {
        private readonly List<MovieInfo> movieList = new List<MovieInfo>();
        private readonly List<CheckBox> seatCheckBoxes = new List<CheckBox>();
        public FormBai05()
        {
            InitializeComponent();
            RegisterSeatCheckBoxes();   
        }
        private void RegisterSeatCheckBoxes()
        {
            seatCheckBoxes.AddRange(new[]
            {
                chkA1, chkA2, chkA3, chkA4, chkA5,
                chkB1, chkB2, chkB3, chkB4, chkB5,
                chkC1, chkC2, chkC3, chkC4, chkC5
            });
        }
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                movieList.Clear();
                cboMovie.Items.Clear();

                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string movieName = streamReader.ReadLine() ?? string.Empty;
                        string priceStr = streamReader.ReadLine() ?? "0";
                        string roomsStr = streamReader.ReadLine() ?? string.Empty;

                        if (string.IsNullOrWhiteSpace(movieName)) break;

                        double.TryParse(priceStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double basePrice);

                        List<int> roomList = new List<int>();
                        string[] roomParts = roomsStr.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string part in roomParts)
                        {
                            if (int.TryParse(part, out int roomNum))
                            {
                                roomList.Add(roomNum);
                            }
                        }

                        MovieInfo movie = new MovieInfo
                        {
                            Name = movieName.Trim(),
                            BasePrice = basePrice,
                            Rooms = roomList
                        };

                        foreach (int roomNum in roomList)
                        {
                            movie.SoldSeatsPerRoom[roomNum] = new HashSet<string>();
                        }

                        movieList.Add(movie);
                        cboMovie.Items.Add(movie.Name);
                    }
                }

                if (cboMovie.Items.Count > 0)
                {
                    cboMovie.SelectedIndex = 0;
                }

                MessageBox.Show("Đã đọc danh sách phim từ file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboRoom.Items.Clear();
            if (cboMovie.SelectedIndex < 0 || cboMovie.SelectedIndex >= movieList.Count) return;

            MovieInfo selectedMovie = movieList[cboMovie.SelectedIndex];
            foreach (int room in selectedMovie.Rooms)
            {
                cboRoom.Items.Add($"Phòng {room}");
            }

            if (cboRoom.Items.Count > 0)
            {
                cboRoom.SelectedIndex = 0;
            }
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSeatStatuses();
        }

        private void UpdateSeatStatuses()
        {
            if (cboMovie.SelectedIndex < 0 || cboRoom.SelectedIndex < 0) return;

            MovieInfo selectedMovie = movieList[cboMovie.SelectedIndex];
            int selectedRoom = selectedMovie.Rooms[cboRoom.SelectedIndex];
            HashSet<string> soldSeats = selectedMovie.SoldSeatsPerRoom[selectedRoom];

            foreach (CheckBox chk in seatCheckBoxes)
            {
                if (soldSeats.Contains(chk.Text))
                {
                    chk.Checked = true;
                    chk.Enabled = false;
                }
                else
                {
                    chk.Checked = false;
                    chk.Enabled = true;
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMovie.SelectedIndex < 0 || cboRoom.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MovieInfo selectedMovie = movieList[cboMovie.SelectedIndex];
            int selectedRoom = selectedMovie.Rooms[cboRoom.SelectedIndex];
            HashSet<string> soldSeats = selectedMovie.SoldSeatsPerRoom[selectedRoom];

            List<string> newlySelectedSeats = new List<string>();
            foreach (CheckBox chk in seatCheckBoxes)
            {
                if (chk.Enabled && chk.Checked)
                {
                    newlySelectedSeats.Add(chk.Text);
                }
            }

            if (newlySelectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalPayment = 0;
            foreach (string seat in newlySelectedSeats)
            {
                double multiplier = GetSeatMultiplier(seat);
                totalPayment += selectedMovie.BasePrice * multiplier;
                soldSeats.Add(seat);
            }

            selectedMovie.TotalRevenue += totalPayment;

            StringBuilder receiptBuilder = new StringBuilder();
            receiptBuilder.AppendLine("----- HÓA ĐƠN BÁN VÉ -----");
            receiptBuilder.AppendLine($"Khách hàng: {txtCustomerName.Text.Trim()}");
            receiptBuilder.AppendLine($"Phim: {selectedMovie.Name}");
            receiptBuilder.AppendLine($"Phòng chiếu: {selectedRoom}");
            receiptBuilder.AppendLine($"Ghế chọn: {string.Join(", ", newlySelectedSeats)}");
            receiptBuilder.AppendLine($"Tổng tiền: {totalPayment:N0} VNĐ");
            receiptBuilder.AppendLine("---------------------------");

            rtbReport.Text = receiptBuilder.ToString();
            MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSeatStatuses();
        }

        private double GetSeatMultiplier(string seatName)
        {
            switch (seatName)
            {
                case "A1":
                case "A5":
                case "C1":
                case "C5":
                    return 0.25;
                case "B2":
                case "B3":
                case "B4":
                    return 2.0;
                default:
                    return 1.0;
            }
        }

        private async void btnExportReport_Click(object sender, EventArgs e)
        {
            if (movieList.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                progressBar.Value = 0;
                progressBar.Maximum = movieList.Count;

                List<MovieReportItem> reportItems = new List<MovieReportItem>();

                for (int i = 0; i < movieList.Count; i++)
                {
                    MovieInfo movie = movieList[i];
                    int totalSeats = movie.Rooms.Count * 15;
                    int soldCount = 0;
                    foreach (var pair in movie.SoldSeatsPerRoom)
                    {
                        soldCount += pair.Value.Count;
                    }

                    int remainingCount = totalSeats - soldCount;
                    double soldRate = totalSeats > 0 ? ((double)soldCount / totalSeats) * 100 : 0;

                    reportItems.Add(new MovieReportItem
                    {
                        Movie = movie,
                        SoldTickets = soldCount,
                        RemainingTickets = remainingCount,
                        SoldRate = soldRate,
                        Revenue = movie.TotalRevenue
                    });

                    progressBar.Value = i + 1;
                    await Task.Delay(200);
                }

                var rankedItems = reportItems.OrderByDescending(x => x.Revenue).ToList();
                for (int i = 0; i < rankedItems.Count; i++)
                {
                    rankedItems[i].Rank = i + 1;
                }

                StringBuilder reportBuilder = new StringBuilder();
                reportBuilder.AppendLine("========== BÁO CÁO THỐNG KÊ DOANH THU PhÌM ==========");
                reportBuilder.AppendLine();

                foreach (var item in reportItems)
                {
                    reportBuilder.AppendLine($"Tên phim: {item.Movie.Name}");
                    reportBuilder.AppendLine($"Số lượng vé bán ra: {item.SoldTickets}");
                    reportBuilder.AppendLine($"Số lượng vé tồn: {item.RemainingTickets}");
                    reportBuilder.AppendLine($"Tỉ lệ vé bán ra: {item.SoldRate:F2}%");
                    reportBuilder.AppendLine($"Doanh thu: {item.Revenue:N0} VNĐ");
                    reportBuilder.AppendLine($"Xếp hạng doanh thu: {item.Rank}");
                    reportBuilder.AppendLine("--------------------------------------------------");
                }

                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    await streamWriter.WriteAsync(reportBuilder.ToString());
                }

                rtbReport.Text = reportBuilder.ToString();
                MessageBox.Show("Đã xuất báo cáo output5.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class MovieInfo
    {
        public string Name { get; set; } = string.Empty;
        public double BasePrice { get; set; }
        public List<int> Rooms { get; set; } = new List<int>();
        public Dictionary<int, HashSet<string>> SoldSeatsPerRoom { get; set; } = new Dictionary<int, HashSet<string>>();
        public double TotalRevenue { get; set; }
    }

    public class MovieReportItem
    {
        public MovieInfo Movie { get; set; } = new MovieInfo();
        public int SoldTickets { get; set; }
        public int RemainingTickets { get; set; }
        public double SoldRate { get; set; }
        public double Revenue { get; set; }
        public int Rank { get; set; }
    }
}

