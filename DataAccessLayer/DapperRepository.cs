using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DapperRepository : IRepository<Student>
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:" +
            "\\Users\\Станислав\\Documents\\progrmming3\\1\\assignment3.1\\DataAccessLayer\\LocalDB.mdf;Integrated Security=True";

        private IDbConnection db;
        public DapperRepository() => db = new SqlConnection(connectionString);

        public IEnumerable<Student> GetStudentsList()
        {
            string sqlQuery = "SELECT * FROM Students";
            try
            {
                db.Open();
                IEnumerable<Student> studentList = db.Query<Student>("SELECT * FROM Students").ToList();
                db.Close();
                return studentList;
            }
            catch (SqlException err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public void Create(Student student)
        {
            string sqlQuery = "INSERT INTO Students (Name, [Group], Speciality) " +
                "VALUES(@Name, @Group, @Speciality); SELECT CAST(SCOPE_IDENTITY() as int)";
            try
            {
                db.Open();
                int studentId = db.Query<int>(sqlQuery, student).FirstOrDefault();
                student.ID = studentId;
                db.Close();
            }
            catch (SqlException err)
            {
                Console.WriteLine(err.Message);
            }

        }


        public void Delete(int ID)
        {
            string sqlQuery = "DELETE FROM Students " +
                "WHERE id = @ID";

            try
            {
                db.Open();
                db.Execute(sqlQuery, new { ID });
                db.Close();
            }
            catch (SqlException err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}

