using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class UserMeal
    {
        public UserMeal()
        {
            UserInformations = new HashSet<UserInformation>();
            FoodNames = new HashSet<FoodName>();
        }
        public int Id { get; set; }
        public DateTime MealDate { get; set; } = DateTime.Now;
        public decimal Portion { get; set; }
        public MealTimesEnum MealTime { get; set; }


        public virtual ICollection<UserInformation> UserInformations { get; set; }

        public virtual ICollection<FoodName> FoodNames { get; set; }
    }
}
