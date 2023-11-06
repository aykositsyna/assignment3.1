using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Windows.Forms.DataVisualization.Charting;

namespace ViewWF
{
    public partial class Form1 : Form
    {
        private Logic logic = new Logic();
        
        public Form1()
        {
            InitializeComponent();
            Render();

        }

        private void AddStudentBttn_Click(object sender, EventArgs e)
        {
            Studentform studentform = new Studentform();
            studentform.DataAvailable += StudentformDataAvaliable;
            studentform.Show();
        }

        private void StudentformDataAvaliable(object sender, Studentform.DataEventArgs e)
        {
            logic.AddStudent(e.Name, e.Speciality, e.Group);
            Render();
        }

        private void RemoveStudentBttn_Click(object sender, EventArgs e)
        {
            if (StudentsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedStudent = StudentsListView.SelectedItems[0];
                if(Int32.TryParse(selectedStudent.SubItems[0].Text, out int studentId))
                {
                    logic.RemoveStudent(studentId);
                }
                Render();
            }
            else
            {
                MessageBox.Show("Wrong index :(");
            }

        }

        public void Render()
        {
            StudentsListView.Items.Clear();
            StudentsListView_Render();
            SpecialityHistogram.Series.Clear();
            SpecialityHistogram_Render();
        }

        private void StudentsListView_Render()
        {
            List<string> students = logic.GetAllStudents();
            foreach(string student in students)
            {
                string[] studentDetails = student.Split('|'); // Split each student string by spaces 0 - name; 1 - speciality; 2 - group
                ListViewItem studentItem = new ListViewItem(studentDetails[0]);

                for ( int i = 1; i < studentDetails.Length; i++ )
                {
                    studentItem.SubItems.Add(studentDetails[i]);
                }
                StudentsListView.Items.Add(studentItem);
            }
        }

        private void SpecialityHistogram_Render()
        {
            Series series = new Series(" ");
            series.ChartType = SeriesChartType.Column;
            Dictionary<string, int> specialities = logic.GetHistogram();
            foreach(KeyValuePair<string, int> speciality in specialities)
            {
                series.Points.AddXY(speciality.Key, speciality.Value);
            }
            SpecialityHistogram.Series.Add(series);
        }      
    }
}
