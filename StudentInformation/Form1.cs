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
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List();
            loadChart();
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

                string json = Utility.ReadFromFile();
                List<Student> lst = new List<Student>();
                if (json != null && json != "")
                {

                    lst = JsonConvert.DeserializeObject<List<Student>>(json);

                }
                lst.Add(s);

                string data = JsonConvert.SerializeObject(lst);
                Utility.WriteToText(data);
                List();
                loadChart();

                //clearing the input fields after the data is written in the file
                txt_name.Clear();
                txt_id.Clear();
                combo_faculty.Text = string.Empty;
                combo_group.Text = string.Empty;
                check_is_active.Checked = false;

                MessageBox.Show("New Student's data added");


            }

            catch (Exception ex)
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

        public void List()

        {
            string json = Utility.ReadFromFile();
            if (json != null && json != "")
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(json);
                dataGridView1.DataSource = lst;
            }

        }

        private void loadChart()
        {
            string data = Utility.ReadFromFile();

            List<Student> lstStudent = JsonConvert.DeserializeObject<List<Student>>(data);

            var groupedData = lstStudent.GroupBy(n => n.Faculty)
                .Select(n => new
                {
                    FacultyName = n.Key,
                    Count = n.Count()
                }).OrderBy(n => n.FacultyName);

            chartStudent.Series[0].LegendText = "Faculty Graph";
            chartStudent.Series[0].ChartType = SeriesChartType.Bar;
            chartStudent.Series[0].IsValueShownAsLabel = true;

            chartStudent.Series[0].XValueMember = "FacultyName";
            chartStudent.Series[0].YValueMembers = "Count";

            chartStudent.DataSource = groupedData;









        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List();

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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
