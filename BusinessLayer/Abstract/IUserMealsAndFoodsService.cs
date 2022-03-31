using Model.Entities;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IUserMealsAndFoodsService<T>
    {
        bool Add(T meal);
        bool UpdateMealAndFood(T _meal);
        bool Delete(int mealId, int foodId);
        decimal GetTotalCalorieById(int userId, DateTime mealDate);
        decimal GetCalorieByMeal(int userId, DateTime mealDate, MealTimesEnum mealTime);

    }
}
