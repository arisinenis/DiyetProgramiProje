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
    public class UserMealService : IUserMealService<UserMeal>
    {
        UserMealRepository userMealRepository;
        public UserMealService()
        {
            userMealRepository = new UserMealRepository();
        }
        public bool Add(UserMeal meal)
        {
            if (String.IsNullOrWhiteSpace(meal.MealDate.ToString()) || String.IsNullOrWhiteSpace(meal.MealTime.ToString()))
            {
                throw new Exception("Please fill all blanks.");
            }
            else
            {
                return userMealRepository.Add(meal);
            }
        }

        public bool Update(UserMeal _meal)
        {
            if (String.IsNullOrWhiteSpace(_meal.MealDate.ToString()) || String.IsNullOrWhiteSpace(_meal.MealTime.ToString()))
            {
                throw new Exception("Please fill all blanks.");
            }
            else
            {
                return userMealRepository.Update(_meal);
            }
        }

        public UserMeal CheckMeal(DateTime dateTime, MealTimesEnum mealTime, int userId)
        {
            return userMealRepository.CheckUserMeal(dateTime, mealTime, userId);
        }

        public UserMeal GetMeal(int userId, DateTime dateTime, MealTimesEnum mealTime)
        {
            return userMealRepository.GetUserMeal(userId, dateTime, mealTime);
        }

        public List<UserMeal> GetAllUserMeal(int userId, DateTime dateTime)
        {
            return userMealRepository.GetAllUserMeal(userId, dateTime);
        }

        public UserMeal GetById(int mealId)
        {
            return userMealRepository.GetById(mealId);
        }
    }
}
