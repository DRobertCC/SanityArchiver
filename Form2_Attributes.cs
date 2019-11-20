using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver_List
{
    public partial class Form2_Attributes : Form
    {
        private string Location { get; }
        private string Filename { get; }
        private string FullPath { get; }
        List<string> attribList;

        public Form2_Attributes(string location, string filename)
        {
            InitializeComponent();
            Location = location;
            Filename = filename;
            FullPath = Location + @"\" + Filename;
        }

        private void Form_Attributes_Load(object sender, EventArgs e)
        {
            textBox_FileName.Text = Filename;
            label_Location.Text = $"Location: {Location}";

            List<String> list = ExistingAttributes();
            for (int i = 0; i < checkedListBox_Attributes.Items.Count; i++)
            {
                if (list.Contains(checkedListBox_Attributes.Items[i].ToString()))
                {
                    checkedListBox_Attributes.SetItemChecked(i, true);
                }
            }
        }

        private List<string> ExistingAttributes()
        {
            FileAttributes attributes = File.GetAttributes(FullPath);
            attribList = new List<string>();
            if ((attributes & FileAttributes.Archive) == FileAttributes.Archive)
            {
                attribList.Add("Archive");
            }

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                attribList.Add("ReadOnly");
            }

            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                attribList.Add("Hidden");
            }

            if ((attributes & FileAttributes.System) == FileAttributes.System)
            {
                attribList.Add("System");
            }

            if ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
            {
                attribList.Add("Encrypted");
            }

            return attribList;
        }

        private void SetAttributes(List<string> checkedList)
        {
            if (checkedList.Contains(FileAttributes.Archive.ToString()))
            {
                File.SetAttributes(FullPath, File.GetAttributes(FullPath) | FileAttributes.Archive);
            }
            else
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(FullPath), FileAttributes.Archive);
                File.SetAttributes(FullPath, attributes);
            }

            if (checkedList.Contains(FileAttributes.ReadOnly.ToString()))
            {
                File.SetAttributes(FullPath, File.GetAttributes(FullPath) | FileAttributes.ReadOnly);
            }
            else
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(FullPath), FileAttributes.ReadOnly);
                File.SetAttributes(FullPath, attributes);
            }

            if (checkedList.Contains(FileAttributes.Hidden.ToString()))
            {
                File.SetAttributes(FullPath, File.GetAttributes(FullPath) | FileAttributes.Hidden);
            }
            else
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(FullPath), FileAttributes.Hidden);
                File.SetAttributes(FullPath, attributes);
            }

            if (checkedList.Contains(FileAttributes.System.ToString()))
            {
                File.SetAttributes(FullPath, File.GetAttributes(FullPath) | FileAttributes.System);
            }
            else
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(FullPath), FileAttributes.System);
                File.SetAttributes(FullPath, attributes);
            }

            if (checkedList.Contains(FileAttributes.Encrypted.ToString()))
            {
                File.SetAttributes(FullPath, File.GetAttributes(FullPath) | FileAttributes.Encrypted);
            }
            else
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(FullPath), FileAttributes.Encrypted);
                File.SetAttributes(FullPath, attributes);
            }
        }

        private FileAttributes RemoveAttribute(FileAttributes fileAttributes, FileAttributes toRemove)
        {
            return fileAttributes & ~toRemove;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            ApplyAttributes();
            this.Close();

        }

        private void ApplyAttributes()
        {
            List<string> checkedList = new List<string>();
            for (int i = 0; i < checkedListBox_Attributes.Items.Count; i++)
            {
                if (checkedListBox_Attributes.GetItemChecked(i))
                {
                    checkedList.Add(checkedListBox_Attributes.Items[i].ToString());
                }
            }
            SetAttributes(checkedList);
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            ApplyAttributes();
        }
    }
}
