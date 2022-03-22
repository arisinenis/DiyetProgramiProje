using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class FoodCategoryConfiguration :  EntityTypeConfiguration<FoodCategory>
    {
        public FoodCategoryConfiguration()
        {
            Property(f => f.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.CategoryName).IsRequired();
            HasMany(f => f.FoodNames).WithRequired(f => f.FoodCategory).HasForeignKey(f => f.FoodCategoryId);
        }
    }
}
