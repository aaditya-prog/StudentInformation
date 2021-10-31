
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_student_name
            // 
            this.label_student_name.AutoSize = true;
            this.label_student_name.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_name.ForeColor = System.Drawing.Color.Blue;
            this.label_student_name.Location = new System.Drawing.Point(41, 86);
            this.label_student_name.Name = "label_student_name";
            this.label_student_name.Size = new System.Drawing.Size(97, 19);
            this.label_student_name.TabIndex = 0;
            this.label_student_name.Text = "Student Name";
            // 
            // label_student_id
            // 
            this.label_student_id.AutoSize = true;
            this.label_student_id.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_id.ForeColor = System.Drawing.Color.Blue;
            this.label_student_id.Location = new System.Drawing.Point(36, 161);
            this.label_student_id.Name = "label_student_id";
            this.label_student_id.Size = new System.Drawing.Size(75, 19);
            this.label_student_id.TabIndex = 1;
            this.label_student_id.Text = "Student ID";
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_faculty.ForeColor = System.Drawing.Color.Blue;
            this.label_faculty.Location = new System.Drawing.Point(41, 241);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(52, 19);
            this.label_faculty.TabIndex = 2;
            this.label_faculty.Text = "Faculty";
            // 
            // label_is_active
            // 
            this.label_is_active.AutoSize = true;
            this.label_is_active.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_is_active.ForeColor = System.Drawing.Color.Blue;
            this.label_is_active.Location = new System.Drawing.Point(36, 416);
            this.label_is_active.Name = "label_is_active";
            this.label_is_active.Size = new System.Drawing.Size(58, 19);
            this.label_is_active.TabIndex = 3;
            this.label_is_active.Text = "Is active";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(40, 116);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(233, 25);
            this.txt_name.TabIndex = 4;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(40, 192);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(233, 25);
            this.txt_id.TabIndex = 6;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // combo_faculty
            // 
            this.combo_faculty.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_faculty.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_faculty.FormattingEnabled = true;
            this.combo_faculty.Items.AddRange(new object[] {
            "Computing",
            "Networking",
            "Multimedia"});
            this.combo_faculty.Location = new System.Drawing.Point(40, 273);
            this.combo_faculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_faculty.Name = "combo_faculty";
            this.combo_faculty.Size = new System.Drawing.Size(233, 25);
            this.combo_faculty.TabIndex = 7;
            // 
            // check_is_active
            // 
            this.check_is_active.AutoSize = true;
            this.check_is_active.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_is_active.ForeColor = System.Drawing.Color.Blue;
            this.check_is_active.Location = new System.Drawing.Point(104, 414);
            this.check_is_active.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_is_active.Name = "check_is_active";
            this.check_is_active.Size = new System.Drawing.Size(57, 23);
            this.check_is_active.TabIndex = 8;
            this.check_is_active.Text = "True";
            this.check_is_active.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(40, 482);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(98, 35);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(169, 482);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(123, 35);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear Form";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // combo_group
            // 
            this.combo_group.BackColor = System.Drawing.Color.AliceBlue;
            this.combo_group.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_group.FormattingEnabled = true;
            this.combo_group.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4"});
            this.combo_group.Location = new System.Drawing.Point(40, 356);
            this.combo_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_group.Name = "combo_group";
            this.combo_group.Size = new System.Drawing.Size(233, 25);
            this.combo_group.TabIndex = 11;
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_group.ForeColor = System.Drawing.Color.Blue;
            this.lbl_group.Location = new System.Drawing.Point(36, 324);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(48, 19);
            this.lbl_group.TabIndex = 12;
            this.lbl_group.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 27);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 400);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

