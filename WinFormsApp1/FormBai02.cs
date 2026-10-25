using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormBai02 : Form
    {
        public FormBai02()
        {
            InitializeComponent();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                txtFileName.Text = openFileDialog.SafeFileName;
                txtSize.Text = $"{fileInfo.Length} bytes";
                txtUrl.Text = fileInfo.FullName;

                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string fileContent = streamReader.ReadToEnd();
                    rtbContent.Text = fileContent;

                    string[] lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    int lineCount = lines.Length;

                    char[] separators = new char[] { ' ', '\r', '\n', '\t' };
                    string[] words = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    int wordCount = words.Length;

                    int characterCount = fileContent.Length;

                    txtLineCount.Text = lineCount.ToString();
                    txtWordCount.Text = wordCount.ToString();
                    txtCharacterCount.Text = characterCount.ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
