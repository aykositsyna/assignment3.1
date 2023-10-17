using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWF
{
    public partial class Studentform : Form
    {
        Form1 form1;
        Logic logic = form1.logic;

        public Studentform()
        {
            InitializeComponent();
            CenterToScreen();
            this.form1 = form1;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void OkBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTB.Text) || String.IsNullOrEmpty(SpecialityTB.Text) || String.IsNullOrEmpty(GroupTB.Text)) 
            {
                MessageBox.Show("No info entered :(");
            }
            else
            {
                form1.logic.AddStudent(NameTB.Text, SpecialityTB.Text, GroupTB.Text);
                form1.Refresh();
            }
            this.Hide();
        }
    }
}
