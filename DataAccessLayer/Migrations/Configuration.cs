namespace DataAccessLayer.Migrations
{
    using Model.Entities;
    using Model.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.IO;
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

            //Image img = new Bitmap(@"C:\Desktop\1.jpg");
            //byte[] arr1;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    arr1 = ms.ToArray();
            //}

            //Dietician dietician1 = new Dietician()
            //{
            //    FirstName = "dietician1",
            //    LastName = "dietician1",
            //    Graduation = "A university",
            //    Status = "Active",
            //    Picture = arr1
            //};

            //context.Dieticians.Add(dietician1);
            //context.SaveChanges();


            //DieticianRegisterInfo dieticianRegisterInfo1 = new DieticianRegisterInfo()
            //{
            //    Id = dietician1.Id,
            //    Email = "dietician1@diet.com",
            //    Password = "1234",
            //    UserType = MembershipTypeEnum.Dietician
            //};

            //context.DieticianRegisterInfos.Add(dieticianRegisterInfo1);
            //context.SaveChanges();


            //UserInformation adminInfo = new UserInformation()
            //{
            //    FirstName = "admin",
            //    LastName = "admin",
            //    BirthDate = DateTime.Now,
            //    Gender = "Male",
            //    Height = 1,
            //    Weight = 1,
            //    Status = "Active",
            //    UserRequest = UserRequestsEnum.MaintainWeight,
            //    DailyExercise = ExerciseEnum.LightlyActive,
            //    DailyCalorie = 2000,
            //    RequireCalorie = 1,
            //    DieticianId = 1
            //};
            //context.UserInformations.Add(adminInfo);
            //context.SaveChanges();

            //UserRegisterInfo admin = new UserRegisterInfo();
            //admin.Id = adminInfo.Id;
            //admin.Email = "admin@diet.com";
            //admin.Password = "1";
            //admin.UserType = MembershipTypeEnum.Admin;

            //context.UserRegisterInfos.Add(admin);
            //context.SaveChanges();


            //UserInformation user1Info = new UserInformation()
            //{
            //    FirstName = "user1",
            //    LastName = "user1",
            //    BirthDate = DateTime.Now,
            //    Gender = "Male",
            //    Height = 178,
            //    Weight = 72,
            //    Status = "Active",
            //    UserRequest = UserRequestsEnum.MaintainWeight,
            //    DailyExercise = ExerciseEnum.LightlyActive,
            //    DailyCalorie = 2000,
            //    RequireCalorie = 2200,
            //    DieticianId = 1
            //};
            //context.UserInformations.Add(user1Info);
            //context.SaveChanges();

            //UserRegisterInfo user1 = new UserRegisterInfo();
            //user1.Id = user1Info.Id;
            //user1.Email = "user1@gmail.com";
            //user1.Password = "1234";
            //user1.UserType = MembershipTypeEnum.Client;

            //context.UserRegisterInfos.Add(user1);
            //context.SaveChanges();


            //FoodCategory category1 = new FoodCategory()
            //{
            //    CategoryName = "Meats",
            //    Status = "Active"
            //};

            //context.FoodCategories.Add(category1);
            //context.SaveChanges();


            //FoodCategory category2 = new FoodCategory()
            //{
            //    CategoryName = "Vegetables",
            //    Status = "Active"
            //};

            //context.FoodCategories.Add(category2);
            //context.SaveChanges();


            //Image food1Img = new Bitmap(@"C:\Desktop\beef.jpg");
            //byte[] arr2;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    food1Img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    arr2 = ms.ToArray();
            //}

            //FoodName food1 = new FoodName()
            //{
            //    Name = "Beef",
            //    Calorie = 300,
            //    Status = "Active",
            //    FoodPicture = arr2,
            //    FoodCategoryId = 1
            //};

            //context.FoodNames.Add(food1);
            //context.SaveChanges();


            //Image food2Img = new Bitmap(@"C:\Desktop\chicken.jpg");
            //byte[] arr3;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    food2Img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    arr3 = ms.ToArray();
            //}

            //FoodName food2 = new FoodName()
            //{
            //    Name = "Chicken",
            //    Calorie = 220,
            //    Status = "Active",
            //    FoodPicture = arr3,
            //    FoodCategoryId = 1
            //};

            //context.FoodNames.Add(food2);
            //context.SaveChanges();


            //Image food3Img = new Bitmap(@"C:\Desktop\bean.jpg");
            //byte[] arr4;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    food3Img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    arr4 = ms.ToArray();
            //}

            //FoodName food3 = new FoodName()
            //{
            //    Name = "Bean",
            //    Calorie = 50,
            //    Status = "Active",
            //    FoodPicture = arr4,
            //    FoodCategoryId = 2
            //};

            //context.FoodNames.Add(food3);
            //context.SaveChanges();


            //Image food4Img = new Bitmap(@"C:\Desktop\broccoli.jpg");
            //byte[] arr5;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    food4Img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    arr5 = ms.ToArray();
            //}

            //FoodName food4 = new FoodName()
            //{
            //    Name = "Broccoli",
            //    Calorie = 27,
            //    Status = "Active",
            //    FoodPicture = arr5,
            //    FoodCategoryId = 2
            //};

            //context.FoodNames.Add(food4);

            //context.SaveChanges();
        }
    }
}
