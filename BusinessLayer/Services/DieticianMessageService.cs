using DataAccessLayer.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class DieticianMessageService
    {
        DieticianMessageRepository dieticianMessageRepository;
        public DieticianMessageService()
        {
            dieticianMessageRepository = new DieticianMessageRepository();
        }
        public bool Add(DieticianMessage message)
        {
           
            return dieticianMessageRepository.Add(message);
        }

        public bool Delete(int messageId)
        {
            return dieticianMessageRepository.Delete(messageId);
        }

        public List<DieticianMessage> GetAll()
        {
            return dieticianMessageRepository.GetAll();
        }

        public List<DieticianMessage> GetByDieticianId(int dieticianId)
        {
            return dieticianMessageRepository.GetByDieticianId(dieticianId);
        }

        public DieticianMessage GetByMessageId(int messageId)
        {
            return dieticianMessageRepository.GetByMessageId(messageId);
        }

        public List<DieticianMessage> GetByUserIdAndDieticianId(int userId, int dieticianId)
        {
            return dieticianMessageRepository.GetByUserIdAndDieticianId(userId,dieticianId);
        }


    }
}
