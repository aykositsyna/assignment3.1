﻿using System;
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
        Logic logic = new Logic();
        
        public Form1()
        {
            InitializeComponent();

            // StudentsListView.Columns.Add("#");
            // StudentsListView.Columns.Add("Students");
            // StudentsListView.Columns.Add("Speciality");
            // StudentsListView.Columns.Add("Group");
            Refresh();

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
            List<string> students = logic.GetAllStudents();
            int i = 1;
            foreach(string student in students)
            {
                string[] studentDetails = student.Split(' '); // Split each student string by spaces 0 - name; 1 - speciality; 2 - group
                ListViewItem studentItem = new ListViewItem(i.ToString());

                foreach(string detail in studentDetails)
                {
                    studentItem.SubItems.Add(detail);
                }
                StudentsListView.Items.Add(studentItem);
                i++;
            }
        }

        private void SpecialityHistogram_Render()
        {

        }

    }
}