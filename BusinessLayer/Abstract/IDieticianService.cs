using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDieticianService<TRegister,TInformation>
    {
        bool AddInformation(TInformation dietician);
        bool AddRegister(TRegister dietician);
        TRegister CheckLogin(string email, string password);
        bool Active(TInformation dietician);
        bool Passive(TInformation dietician);
        List<TInformation> GetActiveAll();
        TInformation GetById(int id);
    }
}
