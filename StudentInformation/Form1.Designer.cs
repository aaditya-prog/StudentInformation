
using System;

namespace StudentInformation
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
            this.label_student_name = new System.Windows.Forms.Label();
            this.label_student_id = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_is_active = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.combo_faculty = new System.Windows.Forms.ComboBox();
            this.check_is_active = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.combo_group = new System.Windows.Forms.ComboBox();
            this.lbl_group = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_student_name
            // 
            this.label_student_name.AutoSize = true;
            this.label_student_name.Location = new System.Drawing.Point(94, 78);
            this.label_student_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_student_name.Name = "label_student_name";
            this.label_student_name.Size = new System.Drawing.Size(75, 13);
            this.label_student_name.TabIndex = 0;
            this.label_student_name.Text = "Student Name";
            // 
            // label_student_id
            // 
            this.label_student_id.AutoSize = true;
            this.label_student_id.Location = new System.Drawing.Point(94, 124);
            this.label_student_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_student_id.Name = "label_student_id";
            this.label_student_id.Size = new System.Drawing.Size(58, 13);
            this.label_student_id.TabIndex = 1;
            this.label_student_id.Text = "Student ID";
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Location = new System.Drawing.Point(94, 175);
            this.label_faculty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(41, 13);
            this.label_faculty.TabIndex = 2;
            this.label_faculty.Text = "Faculty";
            // 
            // label_is_active
            // 
            this.label_is_active.AutoSize = true;
            this.label_is_active.Location = new System.Drawing.Point(94, 265);
            this.label_is_active.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_is_active.Name = "label_is_active";
            this.label_is_active.Size = new System.Drawing.Size(47, 13);
            this.label_is_active.TabIndex = 3;
            this.label_is_active.Text = "Is active";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(184, 78);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(92, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(184, 124);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(92, 20);
            this.txt_id.TabIndex = 6;
            // 
            // combo_faculty
            // 
            this.combo_faculty.FormattingEnabled = true;
            this.combo_faculty.Items.AddRange(new object[] {
            "Computing",
            "Networking",
            "Multimedia"});
            this.combo_faculty.Location = new System.Drawing.Point(184, 172);
            this.combo_faculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_faculty.Name = "combo_faculty";
            this.combo_faculty.Size = new System.Drawing.Size(92, 21);
            this.combo_faculty.TabIndex = 7;
            // 
            // check_is_active
            // 
            this.check_is_active.AutoSize = true;
            this.check_is_active.Location = new System.Drawing.Point(184, 262);
            this.check_is_active.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_is_active.Name = "check_is_active";
            this.check_is_active.Size = new System.Drawing.Size(48, 17);
            this.check_is_active.TabIndex = 8;
            this.check_is_active.Text = "True";
            this.check_is_active.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(184, 307);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(56, 19);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(273, 307);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(56, 19);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // combo_group
            // 
            this.combo_group.FormattingEnabled = true;
            this.combo_group.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4"});
            this.combo_group.Location = new System.Drawing.Point(184, 216);
            this.combo_group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_group.Name = "combo_group";
            this.combo_group.Size = new System.Drawing.Size(92, 21);
            this.combo_group.TabIndex = 11;
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Location = new System.Drawing.Point(94, 219);
            this.lbl_group.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(36, 13);
            this.lbl_group.TabIndex = 12;
            this.lbl_group.Text = "Group";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbl_group);
            this.Controls.Add(this.combo_group);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.check_is_active);
            this.Controls.Add(this.combo_faculty);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label_is_active);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_student_id);
            this.Controls.Add(this.label_student_name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Student Information";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_student_name;
        private System.Windows.Forms.Label label_student_id;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_is_active;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox combo_faculty;
        private System.Windows.Forms.CheckBox check_is_active;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox combo_group;
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
    }
}

