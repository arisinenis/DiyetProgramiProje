using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class UserMealsAndFoodsConfiguration : EntityTypeConfiguration<UserMealsAndFoods>
    {
        public UserMealsAndFoodsConfiguration()
        {
            HasKey(uf => new
            {
                uf.UserMealID, uf.FoodNameID
            });

            HasRequired(u => u.UserMeal).WithMany(u => u.UserMealsAndFoods).HasForeignKey(u => u.UserMealID);
            HasRequired(u => u.FoodName).WithMany(u => u.UserMealsAndFoods).HasForeignKey(u => u.FoodNameID);
        }
    }
}
