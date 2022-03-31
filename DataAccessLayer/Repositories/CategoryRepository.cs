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
    public class CategoryRepository : IStatusRepository<FoodCategory>, IRepository<FoodCategory>
    {
        DietProgramContext db;
        public CategoryRepository()
        {
            db = new DietProgramContext();
        }

        public bool Add(FoodCategory category)
        {
            db.FoodCategories.Add(category);

            return db.SaveChanges() > 0;
        }

        public bool Update(FoodCategory category)
        {
            FoodCategory foodCategory = db.FoodCategories.Find(category.Id);
            foodCategory.CategoryName = category.CategoryName;

            return db.SaveChanges() > 0;
        }

        public bool Active(FoodCategory entity)
        {
            FoodCategory foodCategory = db.FoodCategories.Find(entity.Id);
            foodCategory.Status = "Active";

            return db.SaveChanges() > 0;
        }

        public bool Passive(FoodCategory entity)
        {
            FoodCategory foodCategory = db.FoodCategories.Find(entity.Id);
            foodCategory.Status = "Passive";

            return db.SaveChanges() > 0;
        }

        public List<FoodCategory> GetAll()
        {
            return db.FoodCategories.ToList();
        }

        public FoodCategory GetById(int id)
        {
            return db.FoodCategories.Find(id);
        }

        public List<FoodCategory> GetActives()
        {
            return db.FoodCategories.Where(f => f.Status == "Active").ToList();
        }

        public List<FoodCategory> GetPassives()
        {
            return db.FoodCategories.Where(f => f.Status == "Passive").ToList();
        }

        public List<FoodCategory> GetByFilter(string filter)
        {
            List<FoodCategory> foodCategories = db.FoodCategories.Where(f => f.CategoryName.Contains(filter)).ToList();
            return foodCategories;
        }


    }
}
