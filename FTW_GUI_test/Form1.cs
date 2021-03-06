﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
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
        List<TM> TMList = new List<TM>();


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
            e.Effect = DragDropEffects.Copy;
        }

        private void FileList_txtBox_DragDrop(object sender, DragEventArgs e)
        {
            FileList_txtBox.Text = string.Empty;
            int counter = 0;

            string[] draggedItems = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (var draggedItem in draggedItems)
            {

                var attribute = File.GetAttributes(draggedItem);

                if (attribute.HasFlag(FileAttributes.Directory))
                {
                    String[] allfiles = Directory.GetFiles(draggedItem, "*.docx", SearchOption.AllDirectories);

                    foreach (var file in allfiles)
                    {
                        FileList_txtBox.Text += file + Environment.NewLine;
                        counter++;
                    }
                }

                if (draggedItem.EndsWith(".docx"))
                {
                    FileList_txtBox.Text += draggedItem + Environment.NewLine;
                    counter++;
                }



            }


            FileCountNumber_label.Text = counter.ToString();

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


            Login_txtBox.Text = Environment.UserName + "@lionbridge.com";
            if (Properties.Settings.Default.password != string.Empty)
            {
                Password_txtBox.Text = Properties.Settings.Default.password;
            }

            if (Properties.Settings.Default.SourceLang != string.Empty)
            {
                SourceLang_txtBox.Text = Properties.Settings.Default.SourceLang;
            }

            if (Properties.Settings.Default.TargetLangs != string.Empty)
            {
                TargetLangs_txtBox.Text = Properties.Settings.Default.TargetLangs;
            }


            if (Properties.Settings.Default.appSettings != null)
            {
                string[] checkboxArray = new string[Properties.Settings.Default.appSettings.Count];

                Properties.Settings.Default.appSettings.CopyTo(checkboxArray, 0);

                foreach (var item in checkboxArray)
                {
                    string[] temp = item.Split(':');
                    string chckboxName = temp[0];
                    string chckboxStatus = temp[1];

                    foreach (var control in this.Controls)
                    {
                        if (control is CheckBox)
                        {
                            CheckBox chckbx = control as CheckBox;
                            if (chckbx.Text == chckboxName)
                            {
                                chckbx.Checked = bool.Parse(chckboxStatus);
                            }

                        }

                    }


                }
            }




            try
            {
                using (Stream stream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "TMList.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    TMList = (List<TM>)bin.Deserialize(stream);
                    foreach (var item in TMList)
                    {
                        ChooseTM_cmbBox.Items.Add(item.TMName);
                    }
                }
            }
            catch (IOException)
            {
            }

            ChooseTM_cmbBox.SelectedIndex = 0;  // TODO to fix, as it throws an AOOR exception (if combobox has no items), swallowed by CLR unless excplicitly marked to break;
                                                // loads first TM on the list - implement loading last used TM



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.SourceLang = SourceLang_txtBox.Text;
            Properties.Settings.Default.TargetLangs = TargetLangs_txtBox.Text;
            Properties.Settings.Default.password = Password_txtBox.Text;

            Properties.Settings.Default.appSettings.Clear();

            foreach (var control in this.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox chckbx = control as CheckBox;
                    Properties.Settings.Default.appSettings.Add(chckbx.Text + ':' + chckbx.Checked);
                }

            }

            Properties.Settings.Default.Save();

        }


        private void AddTM_btn_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Add TM to the menu\n\nExample input:\n\nTMname:logoport.lionbridge.com",
                       "Add TM",
                       "TMname:logoport.lionbridge.com");
            char[] separators = new char[] { ':', ';' };

            if (!string.IsNullOrEmpty(input))
            {
                var addition = input.Split(separators);
                //ChooseTM_cmbBox.Text = newTM[0];
                TM additionalTM = new TM() { TMName = addition[0], Server = addition[1] };

                if (!ChooseTM_cmbBox.Items.Contains(additionalTM.TMName))
                {
                    ChooseTM_cmbBox.Items.Add(additionalTM.TMName);
                    TMList.Add(additionalTM);
                }
                else
                {
                    MessageBox.Show("  Error:  Already on the list!", "Duplicate!");
                }

                ChooseTM_cmbBox.SelectedItem = additionalTM.TMName;

                try
                {
                    using (Stream stream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "TMList.bin", FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, TMList);
                    }
                }
                catch (IOException)
                {
                }

            }

        }

        private void DeleteTM_btn_Click(object sender, EventArgs e)
        {
            TM TMToRemove = null;

            if (TMList.Exists(t => t.TMName == ChooseTM_cmbBox.SelectedItem.ToString())
)
            {
                TMToRemove = TMList.Single(t => t.TMName == ChooseTM_cmbBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Nothing to remove!");
            }


            TMList.Remove(TMToRemove);
            try
            {
                using (Stream stream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "TMList.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, TMList);
                }
            }
            catch (IOException)
            {
            }
            ChooseTM_cmbBox.Items.Remove(ChooseTM_cmbBox.SelectedItem);
            //ChooseTM_cmbBox.SelectedIndex = 0;
            ChooseTM_cmbBox.SelectedItem = TM.LastUsedTM;

        }

        private void TargetLangs_txtBox_Click(object sender, EventArgs e)
        {
            TargetLangs_txtBox.SelectAll();
        }

        private void SourceLang_txtBox_Click(object sender, EventArgs e)
        {
            SourceLang_txtBox.SelectAll();
        }

        private void CreateAnalysis_chckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CreateAnalysis_chckBox.Checked)
            {
                TargetLangs_txtBox.Enabled = true;
            }
            else
            {
                TargetLangs_txtBox.Enabled = false;

            }


        }

        private async void PrepareFiles_Btn_Click(object sender, EventArgs e)
        {

            //get files from textbox

            if (FileList_txtBox.Text != string.Empty)
            {
                string[] filesPaths = FileList_txtBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                List<string> Paths = new List<string>(filesPaths.AsEnumerable());

                string CommonPath = String.Empty;
                string Separator = @"\";


                List<string> SeparatedPath = Paths
                    .First(str => str.Length == Paths.Max(st2 => st2.Length))
                    .Split(new string[] { Separator }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                foreach (string PathSegment in SeparatedPath)
                {
                    if (CommonPath.Length == 0 && Paths.All(str => str.StartsWith(PathSegment)))
                    {
                        CommonPath = PathSegment;
                    }
                    else if (Paths.All(str => str.StartsWith(CommonPath + Separator + PathSegment)))
                    {
                        CommonPath += Separator + PathSegment;
                    }
                    else
                    {
                        break;
                    }
                }

                MessageBox.Show(CommonPath);
            }
            else
            {
                MessageBox.Show("No files!");
            }


























            progressBar1.Maximum = 100+1;
            progressBar1.Step = 1;

            var progress = new Progress<int>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                progressBar1.Value = v;
                progressBar1.Value = v -1;
                progressBar1.Value = v;
                PrepareFiles_Btn.Text = v + "%";

                PrepareFiles_Btn.Enabled = false;
                Close_Btn.Enabled = false;

                if (PrepareFiles_Btn.Text == "100%")
                {
                    PrepareFiles_Btn.Text = "Prepare file(s)";
                    PrepareFiles_Btn.Enabled = true;
                    Close_Btn.Enabled = true;
                }
            });

            // Run operation in another thread
            await Task.Run(() => Worker.DoWork(progress));

            // TODO: Do something after all calculations

        }

        private void ChooseTM_cmbBox_DropDown(object sender, EventArgs e)
        {
            TM.LastUsedTM = ChooseTM_cmbBox.Text;
        }

        private void ClearFiles_btn_Click(object sender, EventArgs e)
        {
            FileList_txtBox.Clear();
            FileCountNumber_label.Text = "0";
        }

        private void TargetLangs_txtBox_TextChanged(object sender, EventArgs e)
        {
            string[] targetLangsArray = TargetLangs_txtBox.Text.Split(',');
            TargetLangsCount_lbl.Text = targetLangsArray.Length.ToString();
        }
    }
}
