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
        public Context() : base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Станислав\\Documents\\progrmming3\\1\\assignment3.1\\DataAccessLayer\\LocalDB.mdf;Integrated Security=True") { }

        public DbSet<Student> Students { get; set; }
    }
}
