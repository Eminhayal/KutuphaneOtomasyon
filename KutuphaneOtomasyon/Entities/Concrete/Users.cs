using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyon.Core.Entities;

namespace KutuphaneOtomasyon.Entities.Concrete
{
    public class Users : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Byte[] Tckn { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Mail { get; set; }
        public  string Status { get; set; }


    }
}
