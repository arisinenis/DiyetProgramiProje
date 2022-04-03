using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService<T>
    {
        bool Add(T message);
        bool Delete(int messageId);
        List<T> GetAll();
        List<T> GetByUserId(int userId);
    }
}
