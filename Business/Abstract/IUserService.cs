using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace KutuphaneOtomasyon.Business.Abstract
{
    public interface IUserService<T>
    {
        IResult Add<T>(T t);

    }
}
