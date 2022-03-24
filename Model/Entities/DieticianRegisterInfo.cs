using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class DieticianRegisterInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public MembershipTypeEnum UserType { get; set; }

        //public virtual int DieticianId { get; set; }
        public virtual Dietician Dietician { get; set; }
    }
}
