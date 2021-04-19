using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyon.Core.Entities;

namespace KutuphaneOtomasyon.Entities.Concrete
{
    public class Category : IEntity
    {
   

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
