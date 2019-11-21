using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace SanityArchiver_List
{
    public partial class Form1 : Form
    {
        String currentPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo dri in DriveInfo.GetDrives())
            {
                comboBox_Drives.Items.Add(dri);
            }
            currentPath = @"Y:\Temp\00_Test Files";
            comboBox_Drives.Text = @"Y:\";
            PopulateListBox(currentPath);
        }

        private void PopulateListBox(String path)
        {
            try
            {
                listBox_Browser.Items.Clear();
                label_CurrentPath.Text = path;
                String[] dirs = Directory.GetDirectories(path);
                int i;
                for (i = 0; i < dirs.Length; i++)
                {
                    string temp = @dirs[i].Replace(path, "").Replace(@"\", "");
                    listBox_Browser.Items.Add("[" + temp + "]");
                }
                String[] files = Directory.GetFiles(path);
                for (i = 0; i < files.Length; i++)
                {
                    string temp = files[i].Replace(path, "").Replace(@"\", "");
                    listBox_Browser.Items.Add(temp);
                }
            }
            catch (Exception ex)
            {
                StepBack();
                MessageBox.Show(ex.Message, "ErrorPop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox_Drives_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                currentPath = comboBox_Drives.SelectedItem.ToString();
                PopulateListBox(currentPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListBox_Browser_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Browser.SelectedItems.Count != 0 && listBox_Browser.SelectedItems[0].ToString().StartsWith("["))
            {
                String currentDir = listBox_Browser.SelectedItems[0].ToString().Remove(0, 1);
                currentDir = currentDir.Remove(currentDir.Length - 1, 1);
                currentPath = currentPath + @"\" + currentDir;
                PopulateListBox(currentPath);
            }
            if (listBox_Browser.SelectedItems.Count != 0 && !listBox_Browser.SelectedItems[0].ToString().StartsWith("["))
            {
                try
                {
                    System.Diagnostics.Process.Start(currentPath + @"\" + listBox_Browser.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StepBack();
        }

        private void StepBack()
        {
            if (Directory.GetParent(currentPath) != null)
            {
                DirectoryInfo parentDir = Directory.GetParent(currentPath);
                currentPath = parentDir.ToString();
                PopulateListBox(currentPath);
            }
        }

        private void Button_ChangeAttributes_Click(object sender, EventArgs e)
        {
            if (listBox_Browser.SelectedItems.Count == 1 && !listBox_Browser.SelectedItem.ToString().StartsWith("["))
            {
                Form2_Attributes form = new Form2_Attributes(currentPath, listBox_Browser.SelectedItem.ToString());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    //GetAllProcess();
                    MessageBox.Show("OK");
                }
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Browser.SelectedItems.Count == 1 && !listBox_Browser.SelectedItem.ToString().StartsWith("["))
            {
                try
                {
                    DeleteFile(currentPath, listBox_Browser.SelectedItem.ToString());
                    PopulateListBox(currentPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteFile(string path, string fileName)
        {
            string filePath = path + @"\" + fileName;
                if (File.Exists(filePath) && (MessageBox.Show($"Are you sure you want to delete '{fileName}'", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    File.Delete(filePath);
                }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            PopulateListBox(currentPath);
        }

        private void Button_Compress_Click(object sender, EventArgs e)
        {
            if (listBox_Browser.SelectedItems.Count != 0 && !listBox_Browser.SelectedItems[0].ToString().StartsWith("["))
            {
                FileInfo fileSelected = new FileInfo(listBox_Browser.SelectedItem.ToString());
                if (fileSelected.Extension != ".gzip")
                {
                    try
                    {
                        CompressFile(currentPath, listBox_Browser.SelectedItem.ToString());
                        PopulateListBox(currentPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        UnCompress(currentPath, listBox_Browser.SelectedItem.ToString());
                        PopulateListBox(currentPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //if (listBox_Browser.SelectedItems.Count != 0 && listBox_Browser.SelectedItems[0].ToString().StartsWith("["))
            //{
            //    CompressDirectory(listBox_Browser.SelectedItem.ToString());
            //}
        }

        public void CompressFile(string location, string filename)
        {
            string filePathAndFilename = location + @"\" + filename;
            string gzipPathAndFilename = location + @"\" + filename + ".gzip";

            using (FileStream inputStream = new FileStream(filePathAndFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (FileStream outputStream = new FileStream(gzipPathAndFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (GZipStream gzip = new GZipStream(outputStream, CompressionMode.Compress))
                    {
                        inputStream.CopyTo(gzip);
                    }
                }
            }
        }

        public void UnCompress(string location, string filename)
        {
            FileInfo fileSelected = new FileInfo(filename);
            FileInfo fileSelectedTo = new FileInfo(filename.Remove(filename.Length - fileSelected.Extension.Length));
            string filePathAndFilename = location + @"\" + fileSelectedTo.Name;
            string gzipPathAndFilename = location + @"\" + filename;

            using (FileStream inputStream = new FileStream(gzipPathAndFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (FileStream outputStream = new FileStream(filePathAndFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (GZipStream gzip = new GZipStream(inputStream, CompressionMode.Decompress))
                    {
                        gzip.CopyTo(outputStream);
                    }
                }
            }
        }







        public static bool IsDirectory(string path)
        {
            System.IO.FileAttributes fa = System.IO.File.GetAttributes(path);
            return (fa & FileAttributes.Directory) != 0;
        }

        public void CompressDirectory(string theDirectoryName)
        {
            String currentDir = theDirectoryName.Remove(0, 1);
            currentDir = currentDir.Remove(currentDir.Length - 1, 1);
            DirectoryInfo directoryPath = new DirectoryInfo(currentPath + @"\" + currentDir);
            foreach (DirectoryInfo directory in directoryPath.GetDirectories())
            {
                var path = directoryPath.FullName;
                var newArchiveName = Regex.Replace(directory.Name, "[0-9]{8}", "20130913");
                newArchiveName = Regex.Replace(newArchiveName, "[_]+", "_");
                string startPath = path + directory.Name;
                string zipPath = path + "" + newArchiveName + ".zip";

                ZipFile.CreateFromDirectory(startPath, zipPath);
            }

        }

        public void DecompressDirectory(string theDirectoryPath)
        {
            DirectoryInfo directoryPath = new DirectoryInfo(theDirectoryPath);
            foreach (FileInfo file in directoryPath.GetFiles())
            {
                var path = directoryPath.FullName;
                string zipPath = path + file.Name;
                string extractPath = Regex.Replace(path + file.Name, ".zip", "");

                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
        }
    }
}
