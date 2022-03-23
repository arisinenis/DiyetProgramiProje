namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.Context;
    using Model.Entities;
    using Model.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Context.DietProgramContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.Context.DietProgramContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            UserRegisterInfo admin = new UserRegisterInfo();
            admin.Email = "admin@admin.com";
            admin.Password = "1";
            admin.UserType = MembershipTypeEnum.Admin;

            context.UserInformations.Add(new UserInformation()
            {
                FirstName = "admin",
                LastName = "admin",
                BirthDate = DateTime.Now,
                Gender = "Male",
                Height = 1,
                Weight = 1,
                Status = "Active",
                UserRequest = UserRequestsEnum.MaintainWeight
            });

            context.UserRegisterInfos.Add(admin);

            context.SaveChanges();
        }
    }
}
