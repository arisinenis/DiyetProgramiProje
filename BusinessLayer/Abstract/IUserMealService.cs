using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserMealService<T>
    {
        bool Add(T meal);
        bool Update(T _meal);
    }
}
