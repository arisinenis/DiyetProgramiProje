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
        UserMealRepository userMealRepository;
        UserRepository userRepository;
        public UserMealsAndFoodsRepository()
        {
            db = new DietProgramContext();
            userMealRepository = new UserMealRepository();
            userRepository = new UserRepository();
        }

        public bool Add(UserMealsAndFoods meal)
        {
            db.UserMealsAndFoods.Add(meal);

            return db.SaveChanges() > 0;
        }

        public bool UpdateMealAndFood(UserMealsAndFoods _meal)
        {
            Delete(_meal.UserMealID, _meal.FoodNameID);
            Add(_meal);

            return db.SaveChanges() > 0;
        }

        public bool Delete(int mealId, int foodId)
        {
            UserMealsAndFoods meal = db.UserMealsAndFoods.Where(u => u.UserMealID == mealId && u.FoodNameID == foodId).SingleOrDefault();
            db.UserMealsAndFoods.Remove(meal);

            return db.SaveChanges() > 0;
        }



        public decimal GetTotalCalorieById(int userId, DateTime mealDate)
        {
            decimal totalCalorie = 0;
            List<UserMeal> meals = userMealRepository.GetAllUserMeal(userId, mealDate);

            foreach (UserMeal item in meals)
            {
                totalCalorie += GetCalorieByMeal(item.UserInformationId, item.MealDate, item.MealTime);
            }

            return totalCalorie;
        }

        public decimal GetCalorieByMeal(int userId, DateTime mealDate, MealTimesEnum mealTime)
        {
            decimal totalCalorieByMeal = 0;

            UserMeal userMeal = userMealRepository.GetUserMeal(userId, mealDate, mealTime);

            if (userMeal != null)
            {
                List<UserMealsAndFoods> meals = db.UserMealsAndFoods.Where(u => u.UserMealID == userMeal.Id).ToList();

                foreach (UserMealsAndFoods item in meals)
                {
                    totalCalorieByMeal += (item.Calorie);
                }
                return totalCalorieByMeal;
            }
            else
            {
                return 0;
            }
        }

        public List<UserMealsAndFoods> GetUserAndFoodByMealId(int mealId)
        {
            return db.UserMealsAndFoods.Where(u => u.UserMealID == mealId).ToList();
        }

        public bool CheckMealAndFoods(int foodId, int mealId)
        {
            UserMealsAndFoods userMealsAndFoods = db.UserMealsAndFoods.Where(u => u.FoodNameID == foodId && u.UserMealID == mealId).SingleOrDefault();

            return userMealsAndFoods != null;
        }


        public UserMealsAndFoods GetMealsAndFoods(int foodId, int mealId)
        {
            UserMealsAndFoods userMealsAndFoods = db.UserMealsAndFoods.Where(u => u.FoodNameID == foodId && u.UserMealID == mealId).SingleOrDefault();

            return userMealsAndFoods;
        }

        public List<int> GetFoodIdbyUserMeal(UserMeal userMeal)
        {
            List<int> foodIds = new List<int>();
            List<UserMealsAndFoods> meals = db.UserMealsAndFoods.Where(u => u.UserMealID == userMeal.Id).ToList();

            foreach (var item in meals)
            {
                foodIds.Add(item.FoodNameID);
            }

            return foodIds;
        }


    }

    
}
