using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FoodRepository : IStatusRepository<FoodName>, IRepository<FoodName>
    {
        DietProgramContext db;
        public FoodRepository()
        {
            db = new DietProgramContext();
        }

        public bool Add(FoodName food)
        {
            db.FoodNames.Add(food);

            return db.SaveChanges() > 0;
        }

        public bool Update(FoodName food)
        {

            FoodName updateFood = db.FoodNames.Find(food.Id);
            updateFood.Name = food.Name;
            updateFood.Calorie = food.Calorie;
            updateFood.Status = food.Status;
            updateFood.FoodPicture = food.FoodPicture;
            updateFood.FoodCategoryId = food.FoodCategoryId;

            return db.SaveChanges() > 0;
        }

        public List<FoodName> GetAll()
        {
            return db.FoodNames.ToList();
        }

        public List<FoodName> GetByFilter(string filter)
        {
            List<FoodName> foodNames = db.FoodNames.Where(f=>f.Name.Contains(filter)).ToList();
            return foodNames;
        }

        public FoodName GetById(int id)
        {
            FoodName food = db.FoodNames.Where(f => f.Id == id).SingleOrDefault();

            return food;
        }

        public bool Active(FoodName entity)
        {
            FoodName food = db.FoodNames.Find(entity.Id);
            food.Status = "Active";

            return db.SaveChanges() > 0;
        }

        public bool Passive(FoodName entity)
        {
            FoodName food = db.FoodNames.Find(entity.Id);
            food.Status = "Passive";

            return db.SaveChanges() > 0;
        }

        public string GetCategoryNameByFoodId(int foodId)
        {
            FoodName food = (FoodName)db.FoodNames.Where(f => f.Id == foodId);
            var categoryName = food.FoodCategory.CategoryName;

            return categoryName;
        }

        public decimal GetCalorieByFoodId(int foodId)
        {
            return db.FoodNames.Find(foodId).Calorie;
        }

        public decimal GetTotalCalorieByPortion(int portion, int foodId)
        {
            FoodName food = db.FoodNames.Find(foodId);

            return food.Calorie * portion;
        }

        public List<FoodName> GetActives()
        {
            List<FoodName> foods = db.FoodNames.Where(f => f.Status == "Active").ToList();

            return foods;
        }

        public List<FoodName> GetPassives()
        {
            List<FoodName> foods = db.FoodNames.Where(f => f.Status == "Passive").ToList();

            return foods;
        }
    }
}
