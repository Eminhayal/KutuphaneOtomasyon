using System;
using System.Collections.Generic;
using System.Text;
using KutuphaneOtomasyon.Core.Entities;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Surname { get; set; }
        public string Publisher { get; set; }
        public string Writer { get; set; }
        public int PageNumber { get; set; }
        public string Category { get; set; }
        public string SaloonShelf { get; set; }
    }
}
