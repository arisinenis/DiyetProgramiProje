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
            if (string.IsNullOrWhiteSpace(message.MessageHeader) || string.IsNullOrWhiteSpace(message.Text))
            {
                throw new Exception("Please fill all blanks");
            }
            else
            {
                return messageRepository.Add(message);
            }
        }

        public bool Delete(int messageId)
        {
            if (messageId < 1)
            {
                throw new Exception("Invalid input");
            }
            else
            {
                return messageRepository.Delete(messageId);
            }
        }

        public List<Message> GetAll()
        {
            return messageRepository.GetAll();
        }

        public List<Message> GetByUserId(int userId)
        {
            if (userId < 1)
            {
                throw new Exception("Invalid input");
            }
            else
            {
                return messageRepository.GetByUserId(userId);
            }
        }

        public Message GetByMessageId(int messageId)
        {
            return messageRepository.GetByMessageId(messageId);
        }
    }
}
