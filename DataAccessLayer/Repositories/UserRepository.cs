using DataAccessLayer.Abstract;
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

            return user;
        }

        public string CheckUserStatus(string email)
        {
            UserRegisterInfo user = db.UserRegisterInfos.Where(u => u.Email == email).FirstOrDefault();
            if (user!=null)
            {
                string status = db.UserInformations.Find(user.Id).Status;
                return status;
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
        public List<UserInformation> GetAllActives()
        {
            return db.UserInformations.Where(u => u.Status == "Active").ToList();
        }

        public List<UserInformation> GetAllClients()
        {
            return db.UserInformations.Where(u => u.UserRegisterInfo.UserType.ToString() == "Client" && u.Id !=1).ToList();
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
            List<UserInformation> customers = db.UserInformations.Where(u => u.DieticianId == dietician.Id && u.Id!=1).ToList();

            return customers;
        }

        public bool Active(UserInformation entity)
        {
            UserInformation passiveUser = db.UserInformations.Find(entity.Id);
            passiveUser.Status = "Active";
            return db.SaveChanges() > 0;
        }

        public bool Passive(UserInformation entity)
        {
            UserInformation userInf = db.UserInformations.Find(entity.Id);
            userInf.Status = "Passive";

            return db.SaveChanges() > 0;
        }

        public UserRegisterInfo GetUserByEmail(string email)
        {
            return db.UserRegisterInfos.Where(u => u.Email == email).SingleOrDefault();
        }

    }
}
