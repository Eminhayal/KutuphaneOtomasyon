using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Form
{
    class Connect
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer("Server=tcp:10.211.55.9,1433;Initial Catalog=DevnotDB;User ID=****;Password=******;");
        }
    }
}
