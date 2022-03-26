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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMealsAndFoods> GetAllMeals(int userId)
        {
            throw new NotImplementedException();
        }

        public List<UserMealsAndFoods> GetAllMealsById(int userId, DateTime mealDate)
        {
            throw new NotImplementedException();
        }

        public List<UserMealsAndFoods> GetById(MealTimesEnum mealTime, DateTime mealDate, int userId)
        {
            throw new NotImplementedException();
        }

        public decimal GetCalorieByMeal(int userId, DateTime mealDate, MealTimesEnum mealTime)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalCalorieById(int userId, DateTime mealDate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMealAndFood(UserMealsAndFoods _meal)
        {
            throw new NotImplementedException();
        }
    }
}
