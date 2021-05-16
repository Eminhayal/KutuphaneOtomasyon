using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace KutuphaneOtomasyon.Form
{
    public class bagla : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=tcp:31.223.14.80,1433;Initial Catalog=DevnotDB;User ID=sa;Password=asd123;");
            
        }
    }
}
