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

            Application.Exit();
        }

        private void Login_txtBox_Click(object sender, EventArgs e)
        {
            if (Login_txtBox.Text == "username@lionbridge.com")
            {
                Login_txtBox.Text = string.Empty;
            }
        }

        private void Password_txtBox_Click(object sender, EventArgs e)
        {
            if (Password_txtBox.Text == "Password")
            {
                Password_txtBox.Text = string.Empty;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            var settingsFromFile = File.ReadAllLines(@"c:\users\zawii\documents\visual studio 2015\Projects\FTW_GUI_test\FTW_GUI_test\settings.txt");

            Login_txtBox.Text = Environment.UserName + "@lionbridge.com"; //settingsFromFile[0]
            Password_txtBox.Text = settingsFromFile[1];

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(@"c:\users\zawii\documents\visual studio 2015\Projects\FTW_GUI_test\FTW_GUI_test\settings.txt", Login_txtBox.Text + Environment.NewLine + Password_txtBox.Text);

        }

        private void AddTM_btn_Click(object sender, EventArgs e)
        {
            //spytaj o nazwe TM i serwer logoport, dodaj do listy przechowujacej TMy
            string input = Microsoft.VisualBasic.Interaction.InputBox("Add TM to the menu\n\nExample input:\n\nTMname:logoport.lionbridge.com",
                       "Add TM",
                       "TMname:logoport.lionbridge.com");
            char[] separators = new char[] { ':', ';' };

            if (!string.IsNullOrEmpty(input))
            {
                var newTM = input.Split(separators);
                ChooseTM_cmbBox.Text = newTM[0];

                //dodac pare TM:logoport do listy
            }

        }
    }
}
