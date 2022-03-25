using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Model.Entities;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserMealsAndFoodsRepository
    {
        DietProgramContext db;
        public UserMealsAndFoodsRepository()
        {
            db = new DietProgramContext();
        }

        public bool UpdateMealAndFood(UserMealsAndFoods _meal)
        {
            UserMealsAndFoods meal = db.UserMealsAndFoods.Find(_meal.UserMealID);
            meal.FoodName.Id = _meal.FoodName.Id;
            meal.Portion = _meal.Portion;
            meal.UserMeal.MealDate = _meal.UserMeal.MealDate;
            meal.UserMeal.MealTime = _meal.UserMeal.MealTime;

            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            UserMealsAndFoods meal = db.UserMealsAndFoods.Find(id);
            db.UserMealsAndFoods.Remove(meal);

            return db.SaveChanges() > 0;
        }

        public UserMealsAndFoods GetById(int id)
        {
            throw new NotImplementedException();
            
        }

        
        public List<UserMealsAndFoods> GetAllByMealTime(MealTimesEnum mealTimes)
        {
            var mealList = db.UserMealsAndFoods.Select(u => new
            {
                u.FoodName,
                u.UserMeal.MealTime,
                u.Calorie
            }).Where(u => u.MealTime == mealTimes);

            return (List<UserMealsAndFoods>)mealList;
        }

    }
}
