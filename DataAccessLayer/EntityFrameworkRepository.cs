using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class EntityFrameworkRepository<T> : IRepository<T> where T : class, IDomainObject, new()
   {
      public Context _context;

      public EntityFrameworkRepository(Context context)
      {
         _context = context;
      }

      public IEnumerable<T> GetStudentsList()
      {
         return _context.Set<T>();
      }

      public void Create(T student)
      {
         _context.Set<T>().Add(student);
         _context.SaveChanges();
      }

      public void Delete(int id)
      {
         T item = _context.Set<T>().Find(id);
         if (item != null)
         {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
         }

      }
   }
 
}
