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

        public bool AddInformation(Dietician dietician)
        {
            if(String.IsNullOrWhiteSpace(dietician.FirstName) || String.IsNullOrWhiteSpace(dietician.LastName) || String.IsNullOrWhiteSpace(dietician.Graduation))
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
            if (String.IsNullOrWhiteSpace(dietician.Email) || String.IsNullOrWhiteSpace(dietician.Password))
            {
                throw new Exception("Please fill all blanks");
            }
            else
            {
                return dieticianRepository.AddRegister(dietician);
            }
        }

        public DieticianRegisterInfo CheckLogin(string email, string password)
        {
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password) || dieticianRepository.CheckStatus(email) == "Passive")
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
