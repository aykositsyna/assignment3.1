using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() : base("DbConnection") { }

        public DbSet<Student> Students { get; set; }
    }

    //public class EntityRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    //{
    //    public Context _context;

    //    public EntityRepository(Context context)
    //    {
    //        _context = context;
    //    }

    //    public IEnumerable<T> GetAll()
    //    {
    //        return _context.Set<T>();
    //    }

    //    public void Create(T obj)
    //    {
    //        _context.Set<T>().Add(obj);
    //    }

    //}
}
