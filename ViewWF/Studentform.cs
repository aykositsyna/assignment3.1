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
        public event EventHandler<DataEventArgs> DataAvailable;

        public class DataEventArgs : EventArgs
        {
            public string Name { get; }
            public string Speciality { get; }
            public string Group { get; }

            public DataEventArgs(string nameTBData, string specialityTBData, string groupTBData) {
                Name = nameTBData;
                Speciality = specialityTBData;
                Group = groupTBData;
            }
        }

        public Studentform()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        { }

        private void OkBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTB.Text) || String.IsNullOrEmpty(SpecialityTB.Text) || String.IsNullOrEmpty(GroupTB.Text)) 
            {
                MessageBox.Show("No info entered :(");
            }
            else
            {
                DataAvailable?.Invoke(this, new DataEventArgs(NameTB.Text, SpecialityTB.Text, GroupTB.Text));
            }
            this.Hide();
        }
    }
}
