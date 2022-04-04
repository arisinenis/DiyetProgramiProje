using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using Model.Entities;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserMealsAndFoodsService : IUserMealsAndFoodsService<UserMealsAndFoods>
    {
        UserMealsAndFoodsRepository userMealsAndFoodsRepository;
        public UserMealsAndFoodsService()
        {
            userMealsAndFoodsRepository = new UserMealsAndFoodsRepository();
        }
        public bool Add(UserMealsAndFoods meal)
        {
            if (String.IsNullOrWhiteSpace(meal.Calorie.ToString()) || String.IsNullOrWhiteSpace(meal.FoodNameID.ToString()) || String.IsNullOrWhiteSpace(meal.Portion.ToString()) || String.IsNullOrWhiteSpace(meal.UserMealID.ToString()))
            {
                throw new Exception("Please fill all blanks");
            }
            else
            {
                return userMealsAndFoodsRepository.Add(meal);
            }
        }

        public bool Delete(int mealId, int foodId)
        {
            if (mealId==0 || foodId==0)
            {
                throw new Exception("Please select a food before delete");
            }
                return userMealsAndFoodsRepository.Delete(mealId, foodId);
        }

        public decimal GetCalorieByMeal(int userId, DateTime mealDate, MealTimesEnum mealTime)
        {
            if (userId < 1 || String.IsNullOrWhiteSpace(mealDate.ToString()) || String.IsNullOrWhiteSpace(mealTime.ToString()))
            {
                throw new Exception("Invalid input");
            }
            else
            {
                return userMealsAndFoodsRepository.GetCalorieByMeal(userId, mealDate, mealTime);
            }
        }

        public decimal GetTotalCalorieById(int userId, DateTime mealDate)
        {
            if (userId < 1 || String.IsNullOrWhiteSpace(mealDate.ToString()))
            {
                throw new Exception("Invalid input");
            }
            else
            {
                return userMealsAndFoodsRepository.GetTotalCalorieById(userId, mealDate);
            }
        }

        public bool UpdateMealAndFood(UserMealsAndFoods _meal)
        {
            if (String.IsNullOrWhiteSpace(_meal.Portion.ToString()))
            {
                throw new Exception("Please fill all blanks");
            }
            else
            {
                return userMealsAndFoodsRepository.UpdateMealAndFood(_meal);
            }
        }

        public List<UserMealsAndFoods> GetUserAndFoodByMealId(int mealId)
        {
            return userMealsAndFoodsRepository.GetUserAndFoodByMealId(mealId);
        }

        public bool CheckMealAndFoods(int foodId, int mealId)
        {
            return userMealsAndFoodsRepository.CheckMealAndFoods(foodId,mealId);
        }

        public UserMealsAndFoods GetMealsAndFoods(int foodId, int mealId)
        {
            return userMealsAndFoodsRepository.GetMealsAndFoods(foodId, mealId);
        }
        public List<int> GetFoodIdbyUserMeal(UserMeal userMeal)
        {
            return userMealsAndFoodsRepository.GetFoodIdbyUserMeal(userMeal);
        }
    }
}
