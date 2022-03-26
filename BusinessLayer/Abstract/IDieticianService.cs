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
        bool Add(TRegister dieticianRegister,TInformation dietician);
        TRegister CheckLogin(string email, string password);
        bool Active(TInformation dietician);
        bool Passive(TInformation dietician);
    }
}
