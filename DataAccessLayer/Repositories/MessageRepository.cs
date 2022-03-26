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
    public class MessageRepository 
    {
        DietProgramContext db;

        public MessageRepository()
        {
            db = new DietProgramContext();
        }

        public bool Add(Message message)
        {
            db.Messages.Add(message);

            return db.SaveChanges() > 0;
        }

        public bool Delete(int messageId)
        {
            Message message = db.Messages.Find(messageId);
            message.Status = "Passive";

            return db.SaveChanges() > 0;
        }

        public List<Message> GetAll()
        {
            return db.Messages.ToList();
        }

        public List<Message> GetByUserId(int userId)
        {
            List<Message> messages = db.Messages.Where(m => m.UserInformationId == userId).ToList();

            return messages;
        }
    }
}
