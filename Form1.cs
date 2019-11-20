using System;
using System.Windows.Forms;
using System.IO;

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
                currentDir = currentDir.Remove(currentDir.Length-1, 1);
                currentPath = currentPath + @"\" + currentDir;
                PopulateListBox(currentPath);
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

        private static bool IsDirectory(string path)
        {
            System.IO.FileAttributes fa = System.IO.File.GetAttributes(path);
            return (fa & FileAttributes.Directory) != 0;
        }
    }
}
