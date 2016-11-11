using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTW_GUI_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LockBasedOnFormatting_chckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LockExceptThisFormatting_chckBox.Checked | LockBasedOnFormatting_chckBox.Checked)
            {
                Formatting_comboBox.Enabled = true;
                LockExceptThisFormatting_chckBox.Checked = false;
            }
            else
            {
                Formatting_comboBox.Enabled = false;

            }
        }

        private void LockExceptThisFormatting_chckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LockBasedOnFormatting_chckBox.Checked | LockExceptThisFormatting_chckBox.Checked)
            {
                Formatting_comboBox.Enabled = true;
                LockBasedOnFormatting_chckBox.Checked = false;
            }
            else
            {
                Formatting_comboBox.Enabled = false;

            }
        }

        private void FileList_txtBox_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.)
            //{
                e.Effect = DragDropEffects.Copy;

            //}
        }

        private void FileList_txtBox_DragDrop(object sender, DragEventArgs e)
        {
            FileList_txtBox.Text = string.Empty;

            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
            foreach (var filepath in FileList)
            {
                FileList_txtBox.Text += filepath + Environment.NewLine;

            }
            FileCountNumber_label.Text = FileList.Length.ToString();

        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       
    }
}
