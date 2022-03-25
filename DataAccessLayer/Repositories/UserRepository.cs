using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : IStatusRepository<UserInformation>, ILogin<UserRegisterInfo>, IRepository<UserInformation>
    {
        DietProgramContext db;
        public UserRepository()
        {
            db = new DietProgramContext();
        }

        public bool AddRegister(UserRegisterInfo user)
        {
            db.UserRegisterInfos.Add(user);
            return db.SaveChanges() > 0;
        }

        public bool AddInformation(UserInformation user)
        {
            db.UserInformations.Add(user);
            return db.SaveChanges() > 0;
        }

        public UserRegisterInfo CheckLogin(string email, string password)
        {
            UserRegisterInfo user = db.UserRegisterInfos.Where(u => u.Email == email && u.Password == password && u.UserInformation.Status == "Active").SingleOrDefault();

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public List<UserInformation> GetAllPassives()
        {
            return db.UserInformations.Where(u => u.Status == "Passive").ToList();
        }

        public UserInformation GetById(int userId)
        {
            return db.UserInformations.Find(userId);
        }

        public List<UserInformation> GetAll()
        {
            return db.UserInformations.ToList();
        }

        public List<UserInformation> GetCustomers(Dietician dietician)
        {
            List<UserInformation> customers = db.UserInformations.Where(u => u.DieticianId == dietician.Id).ToList();

            return customers;
        }

        public void Active(UserInformation entity)
        {
            UserInformation passiveUser = db.UserInformations.Find(entity.Id);
            passiveUser.Status = "Active";
            db.SaveChanges();
        }

        public void Passive(UserInformation entity)
        {
            UserInformation userInf = db.UserInformations.Find(entity.Id);
            userInf.Status = "Passive";

            db.SaveChanges();
        }

        public List<UserMealsAndFoods> GetAllMealsById(int userId)
        {
            //List<UserMealsAndFoods> meals = new List<UserMealsAndFoods>();
            var meals = db.UserMealsAndFoods.Where(u => u.UserMeal.UserInformationId == userId).ToList();

            return meals;
        }



        public decimal TotalCalorieById(int userId)
        {
            decimal TotalCalorie = 0;
            List<UserMealsAndFoods> meals = GetAllMealsById(userId);
            foreach (UserMealsAndFoods item in meals)
            {
                TotalCalorie += (item.Calorie * item.Portion);
            }
            return TotalCalorie;

        }
    }
}
