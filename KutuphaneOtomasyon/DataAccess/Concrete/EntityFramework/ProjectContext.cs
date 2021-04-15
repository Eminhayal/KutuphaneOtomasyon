using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyon.Entities.Concrete;

namespace KutuphaneOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class ProjectContext : DbContext
    {
        // Veritabanı ile bağlantı kurmamızı sağlıyor 
        
        protected override void OnCon













        // Veritabanındaki tablolarımız ile ilişki kurmamız için
        // DbSet<Varlıklarımız> Veritabanında neye karışılık geliyorsa yanına onu yazıyoruz veritabanındaki adı ile 

        public DbSet<User> Users { get; set; } // user tablosu ile bağladımız varlığımız
       
     
    }
