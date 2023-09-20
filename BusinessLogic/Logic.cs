using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessLogic
{
    /// <summary>
    /// logic
    /// </summary>
    public class Logic
    {

        private List<Student> Students { get; set; } = new List<Student>();

        public void AddStudent(string name, string speciality, string group)
        {
            Student student = new Student();
            Students.Add(student);
        }

        public void RemoveStudent(int index)
        {
            Students.RemoveAt(index);
        }

        public List<string> GetAllStudents()
        {
            List<string> result = new List<string>();
            foreach (Student student in Students)
            {
                string str = student.Name + "  " + student.Speciality + "  " + student.Group;
                result.Add(str);
            }
            return result;
        }
    }
}
