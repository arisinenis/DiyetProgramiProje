﻿using BusinessLayer.Abstract;
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

        public bool Add(UserRegisterInfo userRegister, UserInformation userInfo)
        {
            if (String.IsNullOrWhiteSpace(userRegister.Email) || String.IsNullOrWhiteSpace(userRegister.Password) || String.IsNullOrWhiteSpace(userRegister.UserInformation.FirstName) || String.IsNullOrWhiteSpace(userRegister.UserInformation.LastName) || String.IsNullOrWhiteSpace(userRegister.UserInformation.BirthDate.ToString()) || String.IsNullOrWhiteSpace(userRegister.UserInformation.Gender) || String.IsNullOrWhiteSpace(userRegister.UserInformation.Height.ToString()) || String.IsNullOrWhiteSpace(userRegister.UserInformation.Weight.ToString()) || String.IsNullOrWhiteSpace(userRegister.UserInformation.DailyExercise.ToString()) || String.IsNullOrWhiteSpace(userRegister.UserInformation.UserRequest.ToString()) || String.IsNullOrWhiteSpace(userRegister.UserInformation.Dietician.ToString()))
            {
                throw new Exception("Please fill all blanks.");
            }
            else
            {
                bool checkRegister, checkInformation;

                checkRegister = userRepository.AddRegister(userRegister);
                checkInformation = userRepository.AddInformation(userInfo);

                return checkRegister && checkInformation;
            }
        }

        public bool Passive(UserInformation user)
        {
            return userRepository.Passive(user);
        }
    }
}