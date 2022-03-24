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

        public FoodName GetById(int id)
        {
            FoodName food = db.FoodNames.Find(id);

            return food;
        }

        public void Active(FoodName entity)
        {
            FoodName food = db.FoodNames.Find(entity.Id);
            food.Status = "Active";

            db.SaveChanges();
        }

        public void Passive(FoodName entity)
        {
            FoodName food = db.FoodNames.Find(entity.Id);
            food.Status = "Passive";

            db.SaveChanges();
        }
    }
}
