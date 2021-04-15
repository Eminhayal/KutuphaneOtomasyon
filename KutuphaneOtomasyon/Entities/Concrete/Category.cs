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
        private readonly ObservableListSource<User> _users =
            new ObservableListSource<User>();

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ObservableListSource<User> Products { get { return _users; } }
    }
}
