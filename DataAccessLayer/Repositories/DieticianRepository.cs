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
    public class DieticianRepository : IStatusRepository<Dietician>, ILogin<DieticianRegisterInfo>
    {
        DietProgramContext db;
        public DieticianRepository()
        {
            db = new DietProgramContext();
        }   

        public bool AddInformation(Dietician dietician)
        {
            db.Dieticians.Add(dietician);

            return db.SaveChanges() > 0;
        }

        public bool AddRegister(DieticianRegisterInfo dietician)
        {
            db.DieticianRegisterInfos.Add(dietician);

            return db.SaveChanges() > 0;
        }

        public DieticianRegisterInfo CheckLogin(string email, string password)
        {
            DieticianRegisterInfo dietician = db.DieticianRegisterInfos.Where(d => d.Email == email && d.Password == password && d.Dietician.Status == "Active").SingleOrDefault();
                
                return dietician;
        }

        public bool Active(Dietician entity)
        {
            Dietician dietician = db.Dieticians.Find(entity.Id);
            dietician.Status = "Active";

            return db.SaveChanges() > 0;
        }

        public bool Passive(Dietician entity)
        {
            Dietician dietician = db.Dieticians.Find(entity.Id);
            dietician.Status = "Passive";

            return db.SaveChanges() > 0;
        }

        public string CheckStatus(string email)
        {
            DieticianRegisterInfo dietician = db.DieticianRegisterInfos.Where(d => d.Email == email).FirstOrDefault();
            if (dietician!=null)
            {
                string status = db.Dieticians.Find(dietician.Id).Status;
                return status;
            }
            else
            {
                return null;
            }
            

        }

        public List<Dietician> GetActiveAll()
        {

            List<Dietician> dieticians = db.Dieticians.Where(d => d.Status == "Active").ToList();
            return dieticians;
        
        }

        public Dietician GetById(int _Id)
        {
            Dietician dietician = (Dietician)db.Dieticians.Where(d => d.Id == _Id).SingleOrDefault();

            return dietician;
        }
    }
}
