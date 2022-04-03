using Model.Abstract;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class UserMeal : IEntity
    {
        public UserMeal()
        {
            UserMealsAndFoods = new HashSet<UserMealsAndFoods>();
        }
        public int Id { get; set; }
        public DateTime MealDate { get; set; } = DateTime.Now.Date;
        public MealTimesEnum MealTime { get; set; }

        public int UserInformationId { get; set; }
        public virtual UserInformation UserInformation { get; set; }

        public virtual ICollection<UserMealsAndFoods> UserMealsAndFoods { get; set; }
    }
}
