using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace BusinessLogic
{
    /// <summary>
    /// logic
    /// </summary>
    public class Logic
    {
        public EntityFrameworkRepository<Student> repository = new EntityFrameworkRepository<Student>(new Context());

        public int StudentCount => Students.Count;

        private List<Student> Students = new List<Student>()
        {
            new Student() { Name = "Ivan", Speciality = "History", Group = "AB22-02", ID = 111},
            new Student() { Name = "Egor", Speciality = "SKD", Group = "AB10-01", ID = 112}
        };


    /// <summary>
    /// adding new student
    /// </summary>
    /// <param name="name"></param>
    /// <param name="speciality"></param>
    /// <param name="group"></param>
    public void AddStudent(string name, string speciality, string group)
        {
            Student student = new Student() { Name = name, Speciality = speciality, Group = group};
            repository.Create(student);
        }

        /// <summary>
        /// removing student
        /// </summary>
        /// <param name="index"></param>
        public void RemoveStudent(int index)
        {
            repository.Delete(index);
        }

        /// <summary>
        /// get all students
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllStudents()
        {
            List<string> result = new List<string>();
            foreach (Student student in repository.GetStudentsList())
            {
                if (!string.IsNullOrEmpty(student.Name) && !string.IsNullOrEmpty(student.Speciality) && !string.IsNullOrEmpty(student.Group))
                {
                    string str = student.Name + "|" + student.Speciality + "|" + student.Group + "|" + student.ID;
                    result.Add(str);
                }

            }
            return result;
        }


        /// <summary>
        /// creating dictionary for histogram
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetHistogram()
        {
            Dictionary<string, int> res = new Dictionary<string, int>();
            foreach (Student student in Students)
            {
                if (res.ContainsKey(student.Speciality))
                {
                    res[student.Speciality]++;
                }
                else
                {
                    res.Add(student.Speciality, 1);
                }
            }
            return res;
        }

    
    }
}
