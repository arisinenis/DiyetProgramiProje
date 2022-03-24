using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStatusRepository<T>
    {
        void Active(T entity);
        void Passive(T entity);
    }
}
