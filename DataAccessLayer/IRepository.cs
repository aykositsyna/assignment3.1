using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal interface IRepository<T> where T : class, IDomainObject, new()
    {
        IEnumerable<T> GetStudentsList();
        void Create(T student);
        void Delete(int id);
    }
}
