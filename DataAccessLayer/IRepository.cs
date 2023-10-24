using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetStudentsList();
        T GetStudent(int id);
        void Create(T student);
        void Update(T student);
        void Delete(T student);
    }
}
