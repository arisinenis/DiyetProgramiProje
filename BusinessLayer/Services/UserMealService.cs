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
    public class UserMealService : IUserMealService<UserMeal>
    {
        UserMealRepository userMealRepository;
        public UserMealService()
        {
            userMealRepository = new UserMealRepository();
        }
        public bool Add(UserMeal meal)
        {
            throw new NotImplementedException();
        }

        public bool Update(UserMeal _meal)
        {
            throw new NotImplementedException();
        }
    }
}
