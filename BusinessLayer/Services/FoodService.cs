using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class FoodService : IFoodService<FoodName>
    {
        FoodRepository foodRepository;
        public FoodService()
        {
            foodRepository = new FoodRepository();
        }
        public bool Active(FoodName food)
        {
            return foodRepository.Active(food);
        }

        public bool Add(FoodName food)
        {
            if (String.IsNullOrWhiteSpace(food.Name))
            {
                throw new Exception("Please type a food name !");
            }
            else if (String.IsNullOrWhiteSpace(food.Calorie.ToString()))
            {
                throw new Exception("Please type a calorie !");
            }
            //else if (String.IsNullOrWhiteSpace(food.FoodCategory.CategoryName))
            //{
            //    throw new Exception("Please type a categorie name !");
            //}
            else
            {
                return foodRepository.Add(food);
            }
        }

        public List<FoodName> GetActives()
        {
            return foodRepository.GetActives();
        }

        public List<FoodName> GetPassives()
        {
            return foodRepository.GetPassives();
        }

        public List<FoodName> GetAll()
        {
            return foodRepository.GetAll();
        }


        public List<FoodName> GetByFilter(string filter)
        {
            return foodRepository.GetByFilter(filter);
        }

        public FoodName GetById(int id)
        {
            if (id < 1)
            {
                throw new Exception("Invalid input");
            }
            else
            {
                return foodRepository.GetById(id);
            }
        }

        public decimal GetCalorieByFoodId(int foodId)
        {
            if (foodId < 1)
            {
                throw new Exception("Invalid input");
            }
            else
            {
                return foodRepository.GetCalorieByFoodId(foodId);
            }
        }

        public string GetCategoryNameByFoodId(int foodId)
        {
            if (foodId < 1)
            {
                throw new Exception("Invalid input");
            }
            else
            {
                return foodRepository.GetCategoryNameByFoodId(foodId);
            }
        }

        public decimal GetTotalCalorieByPortion(int portion, int foodId)
        {
            if (foodId < 1 || portion < 0.25)
            {
                throw new Exception("Invalid input");
            }
            else
            {
                return foodRepository.GetTotalCalorieByPortion(portion, foodId);
            }
        }

        public bool Passive(FoodName food)
        {
            return foodRepository.Passive(food);
        }

        public bool Update(FoodName food)
        {
            if (String.IsNullOrWhiteSpace(food.Name) || String.IsNullOrWhiteSpace(food.Calorie.ToString()))
            {
                throw new Exception("Please fill all blanks");
            }
            else
            {
                return foodRepository.Update(food);
            }
        }
    }
}
