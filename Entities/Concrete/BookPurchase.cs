using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using KutuphaneOtomasyon.Core.Entities;

namespace Entities.Concrete
{
    public class BookPurchase : IEntity
    {
        public int Id { get; set; }
        public int BooksId { get; set; }
        public string BooksName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
