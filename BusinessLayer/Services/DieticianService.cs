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

        public bool Add(DieticianRegisterInfo dieticianRegister, Dietician dietician)
        {
            if (String.IsNullOrWhiteSpace(dieticianRegister.Email) || String.IsNullOrWhiteSpace(dieticianRegister.Password) || String.IsNullOrWhiteSpace(dietician.FirstName) || String.IsNullOrWhiteSpace(dietician.LastName) || String.IsNullOrWhiteSpace(dietician.Graduation))
            {
                throw new Exception("Please fill all blanks.");
            }
            else
            {
                bool checkRegister, checkInformation;

                checkRegister = dieticianRepository.AddRegister(dieticianRegister);
                checkInformation = dieticianRepository.AddInformation(dietician);

                return checkRegister && checkInformation;
            }
        }

        public DieticianRegisterInfo CheckLogin(string email, string password)
        {
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Please fill email and/or password sections.");
            }
            else if (dieticianRepository.CheckStatus(email) == "Passive")
            {
                throw new Exception("Your membership status is passive.");
            }
            else
            {
                return dieticianRepository.CheckLogin(email, password);
            }
        }

        public bool Passive(Dietician dietician)
        {
            return dieticianRepository.Passive(dietician);
        }
    }
}
