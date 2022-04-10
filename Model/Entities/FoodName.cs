using Model.Abstract;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class FoodName : IEntity
    {
        public FoodName()
        {
            UserMealsAndFoods = new HashSet<UserMealsAndFoods>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Calorie { get; set; }
        public StatusEnum Status { get; set; } = StatusEnum.Passive;
        public byte[] FoodPicture { get; set; }

        public virtual int FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; }

        public virtual ICollection<UserMealsAndFoods> UserMealsAndFoods { get; set; }
    }
}
