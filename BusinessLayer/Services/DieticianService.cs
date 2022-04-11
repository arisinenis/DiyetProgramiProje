using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using Model.Entities;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class DieticianService : IDieticianService<DieticianRegisterInfo, Dietician>
    {
        DieticianRepository dieticianRepository;
        public DieticianService()
        {
            dieticianRepository = new DieticianRepository();
        }
        public bool Active(Dietician dietician)
        {
            return dieticianRepository.Active(dietician);
        }

        public bool AddInformation(Dietician dietician)
        {
            if(string.IsNullOrWhiteSpace(dietician.FirstName) || string.IsNullOrWhiteSpace(dietician.LastName) || string.IsNullOrWhiteSpace(dietician.Graduation))
            {
                throw new Exception("Please fill all blanks");
            }
            else
            {
                return dieticianRepository.AddInformation(dietician);
            }
        }

        public bool AddRegister(DieticianRegisterInfo dietician)
        {
            if (string.IsNullOrWhiteSpace(dietician.Email) || string.IsNullOrWhiteSpace(dietician.Password))
            {
                throw new Exception("Please fill all blanks");
            }
            else if (!dietician.Email.Contains("@") || !dietician.Email.Contains(".com"))
            {
                throw new Exception("Please type a correct email.");
            }
            else if (dietician.Password.Length<6 || dietician.Password.Length>25 || !dietician.Password.Any(c=> char.IsUpper(c)) || !dietician.Password.Any(c => char.IsDigit(c)) || !dietician.Password.Any(c => char.IsPunctuation(c)))
            {
                throw new Exception("Password length must be at least 6 and at most 25 digits and must contain at least one number, capital letter and symbol.");
            }
            else
            {
                return dieticianRepository.AddRegister(dietician);
            }
        }

        public DieticianRegisterInfo CheckLogin(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || dieticianRepository.CheckStatus(email) == StatusEnum.Passive.ToString())
            {
                return null;
            }
            else
            {
                return dieticianRepository.CheckLogin(email, password);
            }
        }

        public List<Dietician> GetActiveAll()
        {
            return dieticianRepository.GetActiveAll();
        }

        public Dietician GetById(int id)
        {
            if (id<1)
            {
                throw new Exception("Invalid Input");
            }
            else
            {
                return dieticianRepository.GetById(id);
            }
        }

        public bool Passive(Dietician dietician)
        {
            return dieticianRepository.Passive(dietician);
        }
    }
}
