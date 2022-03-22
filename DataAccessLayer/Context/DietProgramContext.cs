using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class DietProgramContext : DbContext
    {
        public DietProgramContext() 
            : base("DietProgramContext")
        {

        }

        public DbSet<Dietician> Dieticians { get; set; }
        public DbSet<DieticianRegisterInfo> DieticianRegisterInfos { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FoodName> FoodNames { get; set; }
        public DbSet<MealTime> MealTimes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<UserMeal> UserMeals { get; set; }
        public DbSet<UserRegisterInfo> UserRegisterInfos { get; set; }
        public DbSet<UserRequest> UserRequests { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }
}
