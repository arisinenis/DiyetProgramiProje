using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class MealTime
    {
        public int Id { get; set; }
        public MealTimesEnum Time { get; set; }
    }
}
