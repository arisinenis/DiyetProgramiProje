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
        public void Active(FoodName food)
        {
            throw new NotImplementedException();
        }

        public bool Add(FoodName food)
        {
            throw new NotImplementedException();
        }

        public List<FoodName> GetAll()
        {
            throw new NotImplementedException();
        }

        public FoodName GetById(int id)
        {
            throw new NotImplementedException();
        }

        public decimal GetCalorieByFoodId(int foodId)
        {
            throw new NotImplementedException();
        }

        public string GetCategoryNameByFoodId(int foodId)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalCalorieByPortion(int portion, int foodId)
        {
            throw new NotImplementedException();
        }

        public void Passive(FoodName food)
        {
            throw new NotImplementedException();
        }

        public bool Update(FoodName food)
        {
            throw new NotImplementedException();
        }
    }
}
