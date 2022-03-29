using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    // T1 => Register, T2 => Information
    public interface IUserService<TRegister,TInformation>
    {
        bool AddInformation(TInformation userInfo);
        bool AddRegister(TRegister userRegister);
        TRegister CheckLogin(string email, string password);
        List<TInformation> GetPassives();
        TInformation GetById(int id);
        List<TInformation> GetAll();
        List<TInformation> GetCustomers(Dietician dietician);
        bool Active(TInformation user);
        bool Passive(TInformation user);
    }
}
