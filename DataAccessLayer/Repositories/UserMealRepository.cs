using DataAccessLayer.Context;
using Model.Abstract;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserMealRepository
    {
        DietProgramContext db;
        public UserMealRepository()
        {
            db = new DietProgramContext();
        }
        public bool Add(UserMeal meal)
        {
            db.UserMeals.Add(meal);

            return db.SaveChanges() > 0;
        }

        public bool Update(UserMeal _meal)
        {
            UserMeal meal = db.UserMeals.Find(_meal.Id);
            meal.MealDate = _meal.MealDate;
            meal.MealTime = _meal.MealTime;
            
            return db.SaveChanges() > 0;
        }


    }
}
