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

namespace ViewWF
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            Logic Logic = new Logic();
            InitializeComponent();

            StudentsListView.Columns.Add("Students");
            StudentsListView.Columns.Add("Speciality");
            StudentsListView.Columns.Add("Group");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddStudentBttn_Click(object sender, EventArgs e)
        {

        }

        private void RemoveStudentBttn_Click(object sender, EventArgs e)
        {
            
        }

        private void StudentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Refresh()
        {
            StudentsListView.Items.Clear();
            StudentsListView_Render();
            SpecialityHistogram.Series.Clear();
            SpecialityHistogram_Render();
        }

        private void StudentsListView_Render()
        {

        }

        private void SpecialityHistogram_Render()
        {

        }

    }
}
