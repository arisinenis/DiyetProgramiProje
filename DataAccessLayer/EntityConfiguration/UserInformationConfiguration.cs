using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class UserInformationConfiguration : EntityTypeConfiguration<UserInformation>
    {
        public UserInformationConfiguration()
        {
            Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            Property(u => u.LastName).IsRequired().HasMaxLength(50);
            Property(u => u.BirthDate).IsRequired();
            Property(u => u.Gender).IsRequired().HasMaxLength(6);
            Property(u => u.Height).IsRequired();
            Property(u => u.Weight).IsRequired();
            Property(u => u.Status).IsRequired().HasMaxLength(7);

            HasOptional(u => u.Dietician).WithMany(u => u.UserInformations).HasForeignKey(u => u.DieticianId);


            //HasMany(u => u.UserMeals).WithMany(m => m.UserInformations).Map(um =>
            //{
            //    um.MapLeftKey("UserInfoRefId");
            //    um.MapRightKey("UserMealRefId");
            //    um.ToTable("UserInfosAndMeals");
            //});

            HasMany(u => u.UserMeals).WithRequired(u => u.UserInformation).HasForeignKey(u => u.UserInformationId);

            HasMany(u => u.Messages).WithRequired(u => u.UserInformation).HasForeignKey(u => u.UserInformationId);

            HasOptional(a => a.UserRegisterInfo).WithRequired(a => a.UserInformation);

        }
    }
}
