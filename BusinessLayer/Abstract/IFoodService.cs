using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFoodService<T>
    {
        bool Add(T food);
        bool Update(T food);
        List<T> GetAll();
        T GetById(int id);
        bool Active(T food);
        bool Passive(T food);
        string GetCategoryNameByFoodId(int foodId);
        decimal GetCalorieByFoodId(int foodId);
        decimal GetTotalCalorieByPortion(int portion, int foodId);
        List<T> GetByFilter(string filter);
    }
}
