using DataAccessLayer.Context;
using Model.Abstract;
using Model.Entities;
using Model.Enums;
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

        public UserMeal CheckUserMeal(DateTime dateTime, MealTimesEnum mealTime, int userId)
        {
            UserMeal meal = db.UserMeals.Where(u => u.MealDate == dateTime && u.MealTime == mealTime && u.UserInformationId == userId).SingleOrDefault();

            return meal;
        }

        public UserMeal GetUserMeal(int userId, DateTime dateTime, MealTimesEnum mealTime)
        {
            return db.UserMeals.Where(u => u.UserInformationId == userId && u.MealDate == dateTime && u.MealTime == mealTime).SingleOrDefault();
        }

        public List<UserMeal> GetAllUserMeal(int userId, DateTime dateTime)
        {
            return db.UserMeals.Where(u => u.UserInformationId == userId && u.MealDate == dateTime).ToList();
        }

        public UserMeal GetById(int mealId)
        {
            return db.UserMeals.Where(u=> u.Id==mealId).SingleOrDefault();
        }

        

    }
}
