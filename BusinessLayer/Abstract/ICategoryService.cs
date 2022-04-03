using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService<T>
    {
        bool Add(T category);
        bool Update(T category);
        bool Active(T entity);
        bool Passive(T entity);
        List<T> GetAll();
        T GetById(int id);
        List<T> GetActives();
        List<T> GetPassives();

    }
}
