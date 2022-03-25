using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class FoodNameConfiguration : EntityTypeConfiguration<FoodName>
    {
        public FoodNameConfiguration()
        {
            HasKey(f => f.Id);
            Property(f => f.Name).IsRequired().HasMaxLength(100);
            Property(f => f.Calorie).IsRequired();
            Property(f => f.Status).IsRequired().HasMaxLength(8);
            HasIndex(f => f.Name).IsUnique();

            HasRequired(f => f.FoodCategory).WithMany(f => f.FoodNames).HasForeignKey(f => f.FoodCategoryId);

        }
    }
}
