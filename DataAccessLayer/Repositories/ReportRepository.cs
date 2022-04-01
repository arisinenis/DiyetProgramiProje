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
    public class ReportRepository
    {
        DietProgramContext db;
       
        public ReportRepository()
        {
            db = new DietProgramContext();
        }

        public Dictionary<string, int> GetMostEatenCategories(DateTime dt1, DateTime dt2, MealTimesEnum mealTime)
        {
            Dictionary<string, int> dicts = new Dictionary<string, int>();

            var results = db.UserMeals.Where(u => u.MealDate >= dt1 && u.MealDate <= dt2 && u.MealTime == mealTime)
                .Join(db.UserMealsAndFoods, u => u.Id, mf => mf.UserMealID, (u, mf) => new
                {
                    mf.FoodNameID
                })
                .Join(db.FoodNames, umf => umf.FoodNameID, f => f.Id, (umf, f) => new
                {
                    f.FoodCategoryId
                })
                .Join(db.FoodCategories, umff => umff.FoodCategoryId, c => c.Id, (umff, c) => new
                {
                    c.CategoryName
                })
                .GroupBy(x => x.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    Count = g.Count()
                }).ToList();

            foreach (var item in results)
            {
                dicts.Add(item.CategoryName, item.Count);
            }

            return dicts;
        }
    }
}
