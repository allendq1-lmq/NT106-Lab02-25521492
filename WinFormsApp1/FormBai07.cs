using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormBai07 : Form
    {
        public FormBai07()
        {
            InitializeComponent();
        }

        private void FormBai07_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }

        private void LoadDrives()
        {
            tvDirectory.Nodes.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    TreeNode driveNode = new TreeNode(drive.Name)
                    {
                        Tag = drive.RootDirectory.FullName
                    };
                    driveNode.Nodes.Add(new TreeNode());
                    tvDirectory.Nodes.Add(driveNode);
                }
            }
        }

        private void tvDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentNode = e.Node;
            if (currentNode == null || currentNode.Tag == null) return;

            if (currentNode.Nodes.Count == 1 && string.IsNullOrEmpty(currentNode.Nodes[0].Text))
            {
                currentNode.Nodes.Clear();
                string path = currentNode.Tag.ToString() ?? string.Empty;

                if (Directory.Exists(path))
                {
                    try
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(path);

                        foreach (DirectoryInfo subDir in directoryInfo.GetDirectories())
                        {
                            TreeNode dirNode = new TreeNode(subDir.Name)
                            {
                                Tag = subDir.FullName
                            };
                            dirNode.Nodes.Add(new TreeNode());
                            currentNode.Nodes.Add(dirNode);
                        }

                        foreach (FileInfo file in directoryInfo.GetFiles())
                        {
                            TreeNode fileNode = new TreeNode(file.Name)
                            {
                                Tag = file.FullName
                            };
                            currentNode.Nodes.Add(fileNode);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void tvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode == null || selectedNode.Tag == null) return;

            string path = selectedNode.Tag.ToString() ?? string.Empty;

            if (File.Exists(path))
            {
                DisplayFileContent(path);
            }
        }

        private void DisplayFileContent(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string[] textExtensions = { ".txt", ".cs", ".json", ".log", ".xml", ".html", ".css", ".js", ".md" };

            if (imageExtensions.Contains(extension))
            {
                try
                {
                    rtbContent.Visible = false;
                    picContent.Visible = true;

                    if (picContent.Image != null)
                    {
                        picContent.Image.Dispose();
                        picContent.Image = null;
                    }

                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        picContent.Image = Image.FromStream(fs);
                    }
                }
                catch (Exception)
                {
                    ShowTextContent("Không thể hiển thị tệp hình ảnh này.");
                }
            }
            else if (textExtensions.Contains(extension))
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string text = sr.ReadToEnd();
                        ShowTextContent(text);
                    }
                }
                catch (Exception)
                {
                    ShowTextContent("Không thể đọc tệp văn bản này.");
                }
            }
            else
            {
                ShowTextContent($"Định dạng tệp '{extension}' không được hỗ trợ hiển thị xem trước.");
            }
        }

        private void ShowTextContent(string content)
        {
            if (picContent.Image != null)
            {
                picContent.Image.Dispose();
                picContent.Image = null;
            }
            picContent.Visible = false;
            rtbContent.Visible = true;
            rtbContent.Text = content;
        }
    }
}