using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class UserMealsAndFoods : IEntity
    {
        public int UserMealID { get; set; }
        public int FoodNameID { get; set; }
        public decimal Portion { get; set; }

        public virtual UserMeal UserMeal { get; set; }
        public virtual FoodName FoodName { get; set; }
    }
}
