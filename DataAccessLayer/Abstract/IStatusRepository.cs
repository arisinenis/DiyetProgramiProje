using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStatusRepository<T>
    {
        bool Active(T entity);
        bool Passive(T entity);
    }
}
