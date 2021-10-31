using Newtonsoft.Json;
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
            try
            {
                //string submitted data in respective variables
                string student_name = txt_name.Text;
                string student_id = txt_id.Text;
                string faculty = combo_faculty.Text;
                string group = combo_group.Text;
                string is_active = check_is_active.Text;

                //creating an object of 'Student' class
                Student s = new Student();

                //storing the values from the variables in the object
                s.StudentName = student_name;
                s.StudentId = int.Parse(student_id);
                s.Faculty = faculty;
                s.Group = group;
                s.IsActive = bool.Parse(is_active);

                //converting data into JSON format
                string data = JsonConvert.SerializeObject(s);
                //using the function from 'Utility' class to write in the JSON
                //formatted data in the file
                Utility.WriteToText(data);

                //clearing the input fields after the data is written in the file
                txt_name.Clear();
                txt_id.Clear();
                combo_faculty.Text = string.Empty;
                combo_group.Text = string.Empty;
                check_is_active.Checked = false;

                MessageBox.Show("New Student's data added");


            }

            catch(Exception ex)
            { 
                Console.WriteLine(ex);
            
            }
    
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_id.Clear();
            combo_faculty.Text = string.Empty;
            combo_group.Text = string.Empty;
            check_is_active.Checked = false;
        }

        //public static void EmptyTextBoxes(Control parent)
        //{
        //    foreach (Control c in parent.Controls)
        //    {
        //        if (c.GetType() == typeof(TextBox))
        //        {
        //            ((TextBox)(c)).Text = string.Empty;
        //        }
        //    }
        //}

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.ReadFromText();
       
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
