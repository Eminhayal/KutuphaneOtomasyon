using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using KutuphaneOtomasyon.Core.Entities;

namespace Entities.Concrete
{
    public class Admin : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte[] Password { get; set; } //password tipine bakilacak
        public DateTime BirthDate { get; set; }
        public byte[] Tckn { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Mail { get; set; }
        public byte[] Telephone { get; set; }


    }
}
