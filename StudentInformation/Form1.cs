using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    private void btn_submit_Click(object sender, EventArgs e)
        {
            string student_name = txt_name.Text;
            string student_id = txt_id.Text;
            string faculty = combo_faculty.Text;
            string group = combo_group.Text;
            string is_active = check_is_active.Text;

            Student s = new Student();

            s.StudentName = student_name;
            s.StudentId = int.Parse(student_id);
            s.Faculty = faculty;
            s.Group = group;
            s.IsActive = bool.Parse(is_active);
    
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_id.Clear();
            combo_faculty.Text = string.Empty;
            combo_group.Text = string.Empty;
            check_is_active.Checked = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
