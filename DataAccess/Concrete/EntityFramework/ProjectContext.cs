using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Text;
using KutuphaneOtomasyon.Entities.Concrete;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Project;Trusted_Connection=True"); 
            //server

        }

        //Veritabanı Tablolar ile ilişki kurmak bağlamak

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<> Type { get; set; }


    }
}
