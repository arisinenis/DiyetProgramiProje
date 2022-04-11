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
    public class DieticianMessageRepository
    {
        DietProgramContext db;

        public DieticianMessageRepository()
        {
            db = new DietProgramContext();
        }

        public bool Add(DieticianMessage message)
        {
            db.DieticianMessages.Add(message);

            return db.SaveChanges() > 0;
        }

        public bool Delete(int messageId)
        {
            DieticianMessage message = db.DieticianMessages.Find(messageId);
            message.Status = StatusEnum.Passive;

            return db.SaveChanges() > 0;
        }

        public List<DieticianMessage> GetAll()
        {
            return db.DieticianMessages.ToList();
        }

        public List<DieticianMessage> GetByDieticianId(int dieticianId)
        {
            List<DieticianMessage> messages = db.DieticianMessages.Where(m => m.DieticianId == dieticianId).ToList();

            return messages;
        }
        public List<DieticianMessage> GetByUserIdAndDieticianId(int userId, int dieticianId)
        {
            List<DieticianMessage> messages = db.DieticianMessages.Where(m => m.UserId==userId && m.DieticianId == dieticianId).ToList();

            return messages;
        }


        public DieticianMessage GetByMessageId(int messageId)
        {
            return db.DieticianMessages.Find(messageId);
        }
    }
}
