﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class UserInformation
    {
        public UserInformation()
        {
            UserMeals = new HashSet<UserMeal>();
            Messages = new HashSet<Message>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Status { get; set; } = "Passive";

        public virtual int UserRegisterInfoId { get; set; }
        public UserRegisterInfo UserRegisterInfo { get; set; }

        public virtual int UserRequestId { get; set; }
        public UserRequest UserRequest { get; set; }

        public virtual int DieticianId { get; set; }
        public Dietician Dietician { get; set; }

        public virtual ICollection<UserMeal> UserMeals { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}