using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService : IUserService<UserRegisterInfo, UserInformation>
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public bool Active(UserInformation user)
        {
            return userRepository.Active(user);
        }

        public UserRegisterInfo CheckLogin(string email, string password)
        {
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Please fill email and/or password sections.");
            }
            else if (userRepository.CheckUserStatus(email) == "Passive")
            {
                throw new Exception("Your membership status is passive.");
            }
            else
            {
                return userRepository.CheckLogin(email, password);
            }
        }

        public List<UserInformation> GetAll()
        {
            return userRepository.GetAll();
        }

        public UserInformation GetById(int id)
        {
            if (id < 1)
            {
                throw new Exception("Invalid User");
            }
            else
            {
                return userRepository.GetById(id);
            }
        }

        public List<UserInformation> GetCustomers(Dietician dietician)
        {
            return userRepository.GetCustomers(dietician);
        }

        public List<UserInformation> GetPassives()
        {
            return userRepository.GetAllPassives();
        }

       
        public bool AddInformation(UserInformation userInfo)
        {
            if (String.IsNullOrWhiteSpace(userInfo.FirstName) || String.IsNullOrWhiteSpace(userInfo.LastName) || String.IsNullOrWhiteSpace(userInfo.BirthDate.ToString()) || String.IsNullOrWhiteSpace(userInfo.Gender) || String.IsNullOrWhiteSpace(userInfo.Height.ToString()) || String.IsNullOrWhiteSpace(userInfo.Weight.ToString()) || String.IsNullOrWhiteSpace(userInfo.DailyExercise.ToString()) || String.IsNullOrWhiteSpace(userInfo.UserRequest.ToString()) || String.IsNullOrWhiteSpace(userInfo.DieticianId.ToString()) || String.IsNullOrWhiteSpace(userInfo.DailyCalorie.ToString()) || String.IsNullOrWhiteSpace(userInfo.RequireCalorie.ToString()))
            {
                throw new Exception("Please fill all blanks.");
            }
            else
            {
                return userRepository.AddInformation(userInfo);
            }
            
        }

        public bool AddRegister(UserRegisterInfo userRegister)
        {
            if (String.IsNullOrWhiteSpace(userRegister.Email) || String.IsNullOrWhiteSpace(userRegister.Password))
            {
                throw new Exception("Please fill all blanks.");
            }
            else
            {
                return userRepository.AddRegister(userRegister);
            }
        }

        public bool Passive(UserInformation user)
        {
            return userRepository.Passive(user);
        }

        public List<UserInformation> GetAllClients()
        {
            return userRepository.GetAllClients();
        }

        public List<UserInformation> GetAllPassives()
        {
            return userRepository.GetAllPassives();
        }

        public List<UserInformation> GetAllActives()
        {
            return userRepository.GetAllActives();
        }
    }
}
