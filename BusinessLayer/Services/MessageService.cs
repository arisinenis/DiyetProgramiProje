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
    public class MessageService : IMessageService<Message>
    {
        MessageRepository messageRepository;
        public MessageService()
        {
            messageRepository = new MessageRepository();
        }
        public bool Add(Message message)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int messageId)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
