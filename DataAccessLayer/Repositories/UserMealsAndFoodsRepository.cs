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

        public bool Add(UserMealsAndFoods meal)
        {
            db.UserMealsAndFoods.Add(meal);

            return db.SaveChanges() > 0;
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

        //public List<UserMealsAndFoods> GetById(MealTimesEnum mealTime, DateTime mealDate, int userId)
        //{
        //    var mealList = db.UserMealsAndFoods.Select(u => new
        //    {
        //        u.UserMeal.UserInformation.Id,
        //        u.FoodName,
        //        u.UserMeal.MealTime,
        //        u.UserMeal.MealDate,
        //        u.Calorie
        //    }).Where(u => u.MealDate == mealDate && u.MealTime == mealTime && u.Id == userId);

        //    return mealList;
        //}
        
        public List<UserMealsAndFoods> GetAllMeals(int userId)
        {
            var mealList = db.UserMealsAndFoods.Select(u => new
            {
                u.UserMeal.UserInformation.Id,
                u.FoodName,
                u.UserMeal.MealTime,
                u.Calorie
            }).Where(u => u.Id == userId);

            return (List<UserMealsAndFoods>)mealList;
        }

        public List<UserMealsAndFoods> GetAllMealsById(int userId, DateTime mealDate)
        {
            var meals = db.UserMealsAndFoods.Where(u => u.UserMeal.UserInformationId == userId && u.UserMeal.MealDate == mealDate).ToList();

            return meals;
        }

        public decimal GetTotalCalorieById(int userId, DateTime mealDate)
        {
            decimal totalCalorie = 0;
            List<UserMealsAndFoods> meals = GetAllMealsById(userId, mealDate);

            foreach (UserMealsAndFoods item in meals)
            {
                totalCalorie += (item.Calorie * item.Portion);
            }

            return totalCalorie;
        }

        public decimal GetCalorieByMeal(int userId, DateTime mealDate, MealTimesEnum mealTime)
        {
            decimal totalCalorieByMeal = 0;

            List<UserMealsAndFoods> meals = db.UserMealsAndFoods.Where(u => u.UserMeal.UserInformationId == userId && u.UserMeal.MealDate == mealDate && u.UserMeal.MealTime == mealTime).ToList();

            foreach (UserMealsAndFoods item in meals)
            {
                totalCalorieByMeal += (item.Calorie * item.Portion);
            }

            return totalCalorieByMeal;
        }

    }
}
