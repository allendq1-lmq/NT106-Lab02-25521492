using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormBai04 : Form
    {
        private readonly List<Student> inputStudentList = new List<Student>();
        private readonly List<Student> outputStudentList = new List<Student>();
        private int currentStudentIndex = 0;

        public FormBai04()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out Student newStudent)) return;

            inputStudentList.Add(newStudent);
            txtInputAverage.Text = newStudent.AverageScore.ToString("F2", CultureInfo.InvariantCulture);

            UpdateRichTextBoxDisplay();
            ClearInputFields();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if (inputStudentList.Count == 0) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    foreach (Student student in inputStudentList)
                    {
                        streamWriter.WriteLine(student.FullName);
                        streamWriter.WriteLine(student.StudentId);
                        streamWriter.WriteLine(student.PhoneNumber);
                        streamWriter.WriteLine(student.CourseScore1.ToString(CultureInfo.InvariantCulture));
                        streamWriter.WriteLine(student.CourseScore2.ToString(CultureInfo.InvariantCulture));
                        streamWriter.WriteLine(student.CourseScore3.ToString(CultureInfo.InvariantCulture));
                        streamWriter.WriteLine(student.AverageScore.ToString(CultureInfo.InvariantCulture));
                    }
                }
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputStudentList.Clear();

                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string fullName = streamReader.ReadLine() ?? string.Empty;
                        string studentId = streamReader.ReadLine() ?? string.Empty;
                        string phoneNumber = streamReader.ReadLine() ?? string.Empty;
                        string score1Str = streamReader.ReadLine() ?? "0";
                        string score2Str = streamReader.ReadLine() ?? "0";
                        string score3Str = streamReader.ReadLine() ?? "0";
                        string averageStr = streamReader.ReadLine() ?? "0";

                        if (string.IsNullOrWhiteSpace(fullName)) break;

                        double.TryParse(score1Str, NumberStyles.Any, CultureInfo.InvariantCulture, out double score1);
                        double.TryParse(score2Str, NumberStyles.Any, CultureInfo.InvariantCulture, out double score2);
                        double.TryParse(score3Str, NumberStyles.Any, CultureInfo.InvariantCulture, out double score3);

                        Student student = new Student
                        {
                            FullName = fullName,
                            StudentId = studentId,
                            PhoneNumber = phoneNumber,
                            CourseScore1 = score1,
                            CourseScore2 = score2,
                            CourseScore3 = score3
                        };

                        outputStudentList.Add(student);
                    }
                }

                if (outputStudentList.Count > 0)
                {
                    currentStudentIndex = 0;
                    DisplayOutputStudent(currentStudentIndex);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (outputStudentList.Count == 0 || currentStudentIndex <= 0) return;

            currentStudentIndex--;
            DisplayOutputStudent(currentStudentIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (outputStudentList.Count == 0 || currentStudentIndex >= outputStudentList.Count - 1) return;

            currentStudentIndex++;
            DisplayOutputStudent(currentStudentIndex);
        }

        private void DisplayOutputStudent(int index)
        {
            if (index < 0 || index >= outputStudentList.Count) return;

            Student student = outputStudentList[index];
            txtOutputName.Text = student.FullName;
            txtOutputId.Text = student.StudentId;
            txtOutputPhone.Text = student.PhoneNumber;
            txtOutputCourse1.Text = student.CourseScore1.ToString(CultureInfo.InvariantCulture);
            txtOutputCourse2.Text = student.CourseScore2.ToString(CultureInfo.InvariantCulture);
            txtOutputCourse3.Text = student.CourseScore3.ToString(CultureInfo.InvariantCulture);
            txtOutputAverage.Text = student.AverageScore.ToString("F2", CultureInfo.InvariantCulture);

            lblPageIndex.Text = (index + 1).ToString();
        }

        private bool ValidateInput(out Student student)
        {
            student = null;

            if (string.IsNullOrWhiteSpace(txtInputName.Text) || string.IsNullOrWhiteSpace(txtInputId.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên và mã số sinh viên!");
                return false;
            }

            string studentId = txtInputId.Text.Trim();
            if (studentId.Length != 8 || !studentId.All(char.IsDigit))
            {
                MessageBox.Show("Mã số sinh viên phải là một số gồm đúng 8 chữ số!");
                return false;
            }

            string phoneNumber = txtInputPhone.Text.Trim();
            if (phoneNumber.Length != 10 || !phoneNumber.StartsWith("0") || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!");
                return false;
            }

            if (!double.TryParse(txtInputCourse1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double score1) || score1 < 0 || score1 > 10 ||
                !double.TryParse(txtInputCourse2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double score2) || score2 < 0 || score2 > 10 ||
                !double.TryParse(txtInputCourse3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double score3) || score3 < 0 || score3 > 10)
            {
                MessageBox.Show("Điểm của các môn học phải từ 0 đến 10!");
                return false;
            }

            student = new Student
            {
                FullName = txtInputName.Text.Trim(),
                StudentId = studentId,
                PhoneNumber = phoneNumber,
                CourseScore1 = score1,
                CourseScore2 = score2,
                CourseScore3 = score3
            };

            return true;
        }

        private void UpdateRichTextBoxDisplay()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Student student in inputStudentList)
            {
                stringBuilder.AppendLine(student.FullName);
                stringBuilder.AppendLine(student.StudentId);
                stringBuilder.AppendLine(student.PhoneNumber);
                stringBuilder.AppendLine(student.CourseScore1.ToString(CultureInfo.InvariantCulture));
                stringBuilder.AppendLine(student.CourseScore2.ToString(CultureInfo.InvariantCulture));
                stringBuilder.AppendLine(student.CourseScore3.ToString(CultureInfo.InvariantCulture));
                stringBuilder.AppendLine(student.AverageScore.ToString("F2", CultureInfo.InvariantCulture));
                stringBuilder.AppendLine();
            }

            rtbDisplay.Text = stringBuilder.ToString();
        }

        private void ClearInputFields()
        {
            txtInputName.Clear();
            txtInputId.Clear();
            txtInputPhone.Clear();
            txtInputCourse1.Clear();
            txtInputCourse2.Clear();
            txtInputCourse3.Clear();
        }
    }

    public class Student
    {
        public string StudentId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public double CourseScore1 { get; set; }
        public double CourseScore2 { get; set; }
        public double CourseScore3 { get; set; }

        public double AverageScore => (CourseScore1 + CourseScore2 + CourseScore3) / 3.0;
    }
}