namespace FTW_GUI_test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrepareFiles_Btn = new System.Windows.Forms.Button();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.ChooseTM_cmbBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Login_txtBox = new System.Windows.Forms.TextBox();
            this.Password_txtBox = new System.Windows.Forms.TextBox();
            this.FileList_txtBox = new System.Windows.Forms.TextBox();
            this.IncludeSourceFile_chckBox = new System.Windows.Forms.CheckBox();
            this.TrimTags_chckBox = new System.Windows.Forms.CheckBox();
            this.Pseudotranslate_chckBox = new System.Windows.Forms.CheckBox();
            this.OpenXLZ_chckBox = new System.Windows.Forms.CheckBox();
            this.OpenXtrans_chckBox = new System.Windows.Forms.CheckBox();
            this.StandardOptions_label = new System.Windows.Forms.Label();
            this.AdditionalOptions_label = new System.Windows.Forms.Label();
            this.CreateAnalysis_chckBox = new System.Windows.Forms.CheckBox();
            this.UnlockNumbers_chckBox = new System.Windows.Forms.CheckBox();
            this.RunPrepChecker_chckBox = new System.Windows.Forms.CheckBox();
            this.LockBasedOnFormatting_chckBox = new System.Windows.Forms.CheckBox();
            this.LockExceptThisFormatting_chckBox = new System.Windows.Forms.CheckBox();
            this.Formatting_comboBox = new System.Windows.Forms.ComboBox();
            this.FIleCount_label = new System.Windows.Forms.Label();
            this.FileCountNumber_label = new System.Windows.Forms.Label();
            this.AddTM_btn = new System.Windows.Forms.Button();
            this.DeleteTM_btn = new System.Windows.Forms.Button();
            this.SourceLang_txtBox = new System.Windows.Forms.TextBox();
            this.TargetLangs_txtBox = new System.Windows.Forms.TextBox();
            this.ClearFiles_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrepareFiles_Btn
            // 
            this.PrepareFiles_Btn.Location = new System.Drawing.Point(329, 432);
            this.PrepareFiles_Btn.Name = "PrepareFiles_Btn";
            this.PrepareFiles_Btn.Size = new System.Drawing.Size(99, 27);
            this.PrepareFiles_Btn.TabIndex = 0;
            this.PrepareFiles_Btn.Text = "Prepare file(s)";
            this.PrepareFiles_Btn.UseVisualStyleBackColor = true;
            this.PrepareFiles_Btn.Click += new System.EventHandler(this.PrepareFiles_Btn_Click);
            // 
            // Close_Btn
            // 
            this.Close_Btn.Location = new System.Drawing.Point(434, 432);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(99, 27);
            this.Close_Btn.TabIndex = 1;
            this.Close_Btn.Text = "Close";
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // ChooseTM_cmbBox
            // 
            this.ChooseTM_cmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ChooseTM_cmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ChooseTM_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseTM_cmbBox.FormattingEnabled = true;
            this.ChooseTM_cmbBox.Location = new System.Drawing.Point(349, 43);
            this.ChooseTM_cmbBox.Name = "ChooseTM_cmbBox";
            this.ChooseTM_cmbBox.Size = new System.Drawing.Size(182, 21);
            this.ChooseTM_cmbBox.Sorted = true;
            this.ChooseTM_cmbBox.TabIndex = 2;
            this.ChooseTM_cmbBox.DropDown += new System.EventHandler(this.ChooseTM_cmbBox_DropDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 432);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 27);
            this.progressBar1.TabIndex = 3;
            // 
            // Login_txtBox
            // 
            this.Login_txtBox.Location = new System.Drawing.Point(18, 18);
            this.Login_txtBox.MaxLength = 50;
            this.Login_txtBox.Name = "Login_txtBox";
            this.Login_txtBox.Size = new System.Drawing.Size(164, 20);
            this.Login_txtBox.TabIndex = 4;
            this.Login_txtBox.Text = "username@lionbridge.com";
            this.Login_txtBox.Click += new System.EventHandler(this.Login_txtBox_Click);
            // 
            // Password_txtBox
            // 
            this.Password_txtBox.Location = new System.Drawing.Point(18, 44);
            this.Password_txtBox.Name = "Password_txtBox";
            this.Password_txtBox.Size = new System.Drawing.Size(164, 20);
            this.Password_txtBox.TabIndex = 5;
            this.Password_txtBox.Text = "Password";
            this.Password_txtBox.UseSystemPasswordChar = true;
            this.Password_txtBox.Click += new System.EventHandler(this.Password_txtBox_Click);
            // 
            // FileList_txtBox
            // 
            this.FileList_txtBox.AllowDrop = true;
            this.FileList_txtBox.Location = new System.Drawing.Point(18, 116);
            this.FileList_txtBox.Multiline = true;
            this.FileList_txtBox.Name = "FileList_txtBox";
            this.FileList_txtBox.ReadOnly = true;
            this.FileList_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileList_txtBox.Size = new System.Drawing.Size(513, 162);
            this.FileList_txtBox.TabIndex = 6;
            this.FileList_txtBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileList_txtBox_DragDrop);
            this.FileList_txtBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileList_txtBox_DragEnter);
            // 
            // IncludeSourceFile_chckBox
            // 
            this.IncludeSourceFile_chckBox.AutoSize = true;
            this.IncludeSourceFile_chckBox.Checked = true;
            this.IncludeSourceFile_chckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeSourceFile_chckBox.Location = new System.Drawing.Point(29, 322);
            this.IncludeSourceFile_chckBox.Name = "IncludeSourceFile_chckBox";
            this.IncludeSourceFile_chckBox.Size = new System.Drawing.Size(117, 17);
            this.IncludeSourceFile_chckBox.TabIndex = 7;
            this.IncludeSourceFile_chckBox.Text = "Include Source File";
            this.IncludeSourceFile_chckBox.UseVisualStyleBackColor = true;
            // 
            // TrimTags_chckBox
            // 
            this.TrimTags_chckBox.AutoSize = true;
            this.TrimTags_chckBox.Checked = true;
            this.TrimTags_chckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TrimTags_chckBox.Location = new System.Drawing.Point(281, 322);
            this.TrimTags_chckBox.Name = "TrimTags_chckBox";
            this.TrimTags_chckBox.Size = new System.Drawing.Size(73, 17);
            this.TrimTags_chckBox.TabIndex = 8;
            this.TrimTags_chckBox.Text = "Trim Tags";
            this.TrimTags_chckBox.UseVisualStyleBackColor = true;
            // 
            // Pseudotranslate_chckBox
            // 
            this.Pseudotranslate_chckBox.AutoSize = true;
            this.Pseudotranslate_chckBox.Checked = true;
            this.Pseudotranslate_chckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Pseudotranslate_chckBox.Location = new System.Drawing.Point(29, 370);
            this.Pseudotranslate_chckBox.Name = "Pseudotranslate_chckBox";
            this.Pseudotranslate_chckBox.Size = new System.Drawing.Size(102, 17);
            this.Pseudotranslate_chckBox.TabIndex = 9;
            this.Pseudotranslate_chckBox.Text = "Pseudotranslate";
            this.Pseudotranslate_chckBox.UseVisualStyleBackColor = true;
            // 
            // OpenXLZ_chckBox
            // 
            this.OpenXLZ_chckBox.AutoSize = true;
            this.OpenXLZ_chckBox.Checked = true;
            this.OpenXLZ_chckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenXLZ_chckBox.Location = new System.Drawing.Point(29, 354);
            this.OpenXLZ_chckBox.Name = "OpenXLZ_chckBox";
            this.OpenXLZ_chckBox.Size = new System.Drawing.Size(75, 17);
            this.OpenXLZ_chckBox.TabIndex = 10;
            this.OpenXLZ_chckBox.Text = "Open XLZ";
            this.OpenXLZ_chckBox.UseVisualStyleBackColor = true;
            // 
            // OpenXtrans_chckBox
            // 
            this.OpenXtrans_chckBox.AutoSize = true;
            this.OpenXtrans_chckBox.Checked = true;
            this.OpenXtrans_chckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenXtrans_chckBox.Location = new System.Drawing.Point(29, 386);
            this.OpenXtrans_chckBox.Name = "OpenXtrans_chckBox";
            this.OpenXtrans_chckBox.Size = new System.Drawing.Size(156, 17);
            this.OpenXtrans_chckBox.TabIndex = 11;
            this.OpenXtrans_chckBox.Text = "Open Pseudotranslated File";
            this.OpenXtrans_chckBox.UseVisualStyleBackColor = true;
            // 
            // StandardOptions_label
            // 
            this.StandardOptions_label.AutoSize = true;
            this.StandardOptions_label.Font = new System.Drawing.Font("Kokila", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StandardOptions_label.Location = new System.Drawing.Point(26, 292);
            this.StandardOptions_label.Name = "StandardOptions_label";
            this.StandardOptions_label.Size = new System.Drawing.Size(136, 18);
            this.StandardOptions_label.TabIndex = 12;
            this.StandardOptions_label.Text = "Standard Options:";
            // 
            // AdditionalOptions_label
            // 
            this.AdditionalOptions_label.AutoSize = true;
            this.AdditionalOptions_label.Font = new System.Drawing.Font("Kokila", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdditionalOptions_label.Location = new System.Drawing.Point(278, 292);
            this.AdditionalOptions_label.Name = "AdditionalOptions_label";
            this.AdditionalOptions_label.Size = new System.Drawing.Size(142, 18);
            this.AdditionalOptions_label.TabIndex = 13;
            this.AdditionalOptions_label.Text = "Additional Options:";
            // 
            // CreateAnalysis_chckBox
            // 
            this.CreateAnalysis_chckBox.AutoSize = true;
            this.CreateAnalysis_chckBox.Checked = true;
            this.CreateAnalysis_chckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateAnalysis_chckBox.Location = new System.Drawing.Point(29, 338);
            this.CreateAnalysis_chckBox.Name = "CreateAnalysis_chckBox";
            this.CreateAnalysis_chckBox.Size = new System.Drawing.Size(118, 17);
            this.CreateAnalysis_chckBox.TabIndex = 14;
            this.CreateAnalysis_chckBox.Text = "Create Analysis ZIP";
            this.CreateAnalysis_chckBox.UseVisualStyleBackColor = true;
            this.CreateAnalysis_chckBox.CheckedChanged += new System.EventHandler(this.CreateAnalysis_chckBox_CheckedChanged);
            // 
            // UnlockNumbers_chckBox
            // 
            this.UnlockNumbers_chckBox.AutoSize = true;
            this.UnlockNumbers_chckBox.Location = new System.Drawing.Point(281, 338);
            this.UnlockNumbers_chckBox.Name = "UnlockNumbers_chckBox";
            this.UnlockNumbers_chckBox.Size = new System.Drawing.Size(103, 17);
            this.UnlockNumbers_chckBox.TabIndex = 15;
            this.UnlockNumbers_chckBox.Text = "Unlock numbers";
            this.UnlockNumbers_chckBox.UseVisualStyleBackColor = true;
            // 
            // RunPrepChecker_chckBox
            // 
            this.RunPrepChecker_chckBox.AutoSize = true;
            this.RunPrepChecker_chckBox.Location = new System.Drawing.Point(281, 354);
            this.RunPrepChecker_chckBox.Name = "RunPrepChecker_chckBox";
            this.RunPrepChecker_chckBox.Size = new System.Drawing.Size(114, 17);
            this.RunPrepChecker_chckBox.TabIndex = 16;
            this.RunPrepChecker_chckBox.Text = "Run Prep Checker";
            this.RunPrepChecker_chckBox.UseVisualStyleBackColor = true;
            // 
            // LockBasedOnFormatting_chckBox
            // 
            this.LockBasedOnFormatting_chckBox.AutoSize = true;
            this.LockBasedOnFormatting_chckBox.Location = new System.Drawing.Point(281, 370);
            this.LockBasedOnFormatting_chckBox.Name = "LockBasedOnFormatting_chckBox";
            this.LockBasedOnFormatting_chckBox.Size = new System.Drawing.Size(146, 17);
            this.LockBasedOnFormatting_chckBox.TabIndex = 17;
            this.LockBasedOnFormatting_chckBox.Text = "Lock based on formatting";
            this.LockBasedOnFormatting_chckBox.UseVisualStyleBackColor = true;
            this.LockBasedOnFormatting_chckBox.CheckedChanged += new System.EventHandler(this.LockBasedOnFormatting_chckBox_CheckedChanged);
            // 
            // LockExceptThisFormatting_chckBox
            // 
            this.LockExceptThisFormatting_chckBox.AutoSize = true;
            this.LockExceptThisFormatting_chckBox.Location = new System.Drawing.Point(281, 386);
            this.LockExceptThisFormatting_chckBox.Name = "LockExceptThisFormatting_chckBox";
            this.LockExceptThisFormatting_chckBox.Size = new System.Drawing.Size(153, 17);
            this.LockExceptThisFormatting_chckBox.TabIndex = 18;
            this.LockExceptThisFormatting_chckBox.Text = "Lock except this formatting";
            this.LockExceptThisFormatting_chckBox.UseVisualStyleBackColor = true;
            this.LockExceptThisFormatting_chckBox.CheckedChanged += new System.EventHandler(this.LockExceptThisFormatting_chckBox_CheckedChanged);
            // 
            // Formatting_comboBox
            // 
            this.Formatting_comboBox.Enabled = false;
            this.Formatting_comboBox.FormattingEnabled = true;
            this.Formatting_comboBox.Location = new System.Drawing.Point(434, 374);
            this.Formatting_comboBox.Name = "Formatting_comboBox";
            this.Formatting_comboBox.Size = new System.Drawing.Size(100, 21);
            this.Formatting_comboBox.TabIndex = 19;
            this.Formatting_comboBox.Text = "Formatting...";
            // 
            // FIleCount_label
            // 
            this.FIleCount_label.AutoSize = true;
            this.FIleCount_label.Location = new System.Drawing.Point(24, 100);
            this.FIleCount_label.Name = "FIleCount_label";
            this.FIleCount_label.Size = new System.Drawing.Size(57, 13);
            this.FIleCount_label.TabIndex = 20;
            this.FIleCount_label.Text = "File Count:";
            // 
            // FileCountNumber_label
            // 
            this.FileCountNumber_label.AutoSize = true;
            this.FileCountNumber_label.Location = new System.Drawing.Point(78, 100);
            this.FileCountNumber_label.Name = "FileCountNumber_label";
            this.FileCountNumber_label.Size = new System.Drawing.Size(13, 13);
            this.FileCountNumber_label.TabIndex = 21;
            this.FileCountNumber_label.Text = "0";
            // 
            // AddTM_btn
            // 
            this.AddTM_btn.Location = new System.Drawing.Point(349, 18);
            this.AddTM_btn.Name = "AddTM_btn";
            this.AddTM_btn.Size = new System.Drawing.Size(63, 21);
            this.AddTM_btn.TabIndex = 22;
            this.AddTM_btn.Text = "Add TM...";
            this.AddTM_btn.UseVisualStyleBackColor = true;
            this.AddTM_btn.Click += new System.EventHandler(this.AddTM_btn_Click);
            // 
            // DeleteTM_btn
            // 
            this.DeleteTM_btn.Location = new System.Drawing.Point(418, 18);
            this.DeleteTM_btn.Name = "DeleteTM_btn";
            this.DeleteTM_btn.Size = new System.Drawing.Size(63, 21);
            this.DeleteTM_btn.TabIndex = 23;
            this.DeleteTM_btn.Text = "Delete";
            this.DeleteTM_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteTM_btn.UseVisualStyleBackColor = true;
            this.DeleteTM_btn.Click += new System.EventHandler(this.DeleteTM_btn_Click);
            // 
            // SourceLang_txtBox
            // 
            this.SourceLang_txtBox.Location = new System.Drawing.Point(349, 80);
            this.SourceLang_txtBox.Name = "SourceLang_txtBox";
            this.SourceLang_txtBox.Size = new System.Drawing.Size(46, 20);
            this.SourceLang_txtBox.TabIndex = 24;
            this.SourceLang_txtBox.Text = "source";
            this.SourceLang_txtBox.Click += new System.EventHandler(this.SourceLang_txtBox_Click);
            // 
            // TargetLangs_txtBox
            // 
            this.TargetLangs_txtBox.Location = new System.Drawing.Point(401, 80);
            this.TargetLangs_txtBox.Name = "TargetLangs_txtBox";
            this.TargetLangs_txtBox.Size = new System.Drawing.Size(130, 20);
            this.TargetLangs_txtBox.TabIndex = 25;
            this.TargetLangs_txtBox.Text = "target languages";
            this.TargetLangs_txtBox.Click += new System.EventHandler(this.TargetLangs_txtBox_Click);
            // 
            // ClearFiles_btn
            // 
            this.ClearFiles_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.ClearFiles_btn.Location = new System.Drawing.Point(97, 99);
            this.ClearFiles_btn.Name = "ClearFiles_btn";
            this.ClearFiles_btn.Size = new System.Drawing.Size(10, 16);
            this.ClearFiles_btn.TabIndex = 26;
            this.ClearFiles_btn.Text = "X";
            this.ClearFiles_btn.UseVisualStyleBackColor = true;
            this.ClearFiles_btn.Click += new System.EventHandler(this.ClearFiles_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 471);
            this.Controls.Add(this.ClearFiles_btn);
            this.Controls.Add(this.TargetLangs_txtBox);
            this.Controls.Add(this.SourceLang_txtBox);
            this.Controls.Add(this.DeleteTM_btn);
            this.Controls.Add(this.AddTM_btn);
            this.Controls.Add(this.FileCountNumber_label);
            this.Controls.Add(this.FIleCount_label);
            this.Controls.Add(this.Formatting_comboBox);
            this.Controls.Add(this.LockExceptThisFormatting_chckBox);
            this.Controls.Add(this.LockBasedOnFormatting_chckBox);
            this.Controls.Add(this.RunPrepChecker_chckBox);
            this.Controls.Add(this.UnlockNumbers_chckBox);
            this.Controls.Add(this.CreateAnalysis_chckBox);
            this.Controls.Add(this.AdditionalOptions_label);
            this.Controls.Add(this.StandardOptions_label);
            this.Controls.Add(this.OpenXtrans_chckBox);
            this.Controls.Add(this.OpenXLZ_chckBox);
            this.Controls.Add(this.Pseudotranslate_chckBox);
            this.Controls.Add(this.TrimTags_chckBox);
            this.Controls.Add(this.IncludeSourceFile_chckBox);
            this.Controls.Add(this.FileList_txtBox);
            this.Controls.Add(this.Password_txtBox);
            this.Controls.Add(this.Login_txtBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ChooseTM_cmbBox);
            this.Controls.Add(this.Close_Btn);
            this.Controls.Add(this.PrepareFiles_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dr Prepper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrepareFiles_Btn;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.ComboBox ChooseTM_cmbBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox Login_txtBox;
        private System.Windows.Forms.TextBox Password_txtBox;
        private System.Windows.Forms.TextBox FileList_txtBox;
        private System.Windows.Forms.CheckBox IncludeSourceFile_chckBox;
        private System.Windows.Forms.CheckBox TrimTags_chckBox;
        private System.Windows.Forms.CheckBox Pseudotranslate_chckBox;
        private System.Windows.Forms.CheckBox OpenXLZ_chckBox;
        private System.Windows.Forms.CheckBox OpenXtrans_chckBox;
        private System.Windows.Forms.Label StandardOptions_label;
        private System.Windows.Forms.Label AdditionalOptions_label;
        private System.Windows.Forms.CheckBox CreateAnalysis_chckBox;
        private System.Windows.Forms.CheckBox UnlockNumbers_chckBox;
        private System.Windows.Forms.CheckBox RunPrepChecker_chckBox;
        private System.Windows.Forms.CheckBox LockBasedOnFormatting_chckBox;
        private System.Windows.Forms.CheckBox LockExceptThisFormatting_chckBox;
        private System.Windows.Forms.ComboBox Formatting_comboBox;
        private System.Windows.Forms.Label FIleCount_label;
        private System.Windows.Forms.Label FileCountNumber_label;
        private System.Windows.Forms.Button AddTM_btn;
        private System.Windows.Forms.Button DeleteTM_btn;
        private System.Windows.Forms.TextBox SourceLang_txtBox;
        private System.Windows.Forms.TextBox TargetLangs_txtBox;
        private System.Windows.Forms.Button ClearFiles_btn;
    }
}

