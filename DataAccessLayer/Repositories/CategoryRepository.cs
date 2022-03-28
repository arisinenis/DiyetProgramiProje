﻿using DataAccessLayer.Abstract;
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


    }
}