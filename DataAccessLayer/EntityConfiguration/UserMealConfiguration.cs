using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class UserMealConfiguration : EntityTypeConfiguration<UserMeal>
    {
        public UserMealConfiguration()
        {
            Property(u => u.MealDate).IsRequired();
            Property(u => u.Portion).IsRequired();
            Property(u => u.MealTime).IsRequired();

            HasRequired(m => m.UserInformation).WithMany(m => m.UserMeals).HasForeignKey(m => m.UserInformationId);
        }
    }
}
