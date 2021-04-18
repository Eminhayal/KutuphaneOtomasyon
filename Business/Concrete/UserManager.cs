using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using KutuphaneOtomasyon.Business.Abstract;
using KutuphaneOtomasyon.Entities.Concrete;

namespace KutuphaneOtomasyon.Business.Concrete
{
    public class UserManager : IUserService<User>
    {
        public IResult Add<User>(User user)
        {
            throw new NotImplementedException();
        }
    }
}
