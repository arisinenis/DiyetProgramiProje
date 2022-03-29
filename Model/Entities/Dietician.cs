using Model.Abstract;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Dietician : IEntity
    {
        public Dietician()
        {
            UserInformations = new HashSet<UserInformation>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Graduation { get; set; }
        public string Status { get; set; } = "Passive";
        public byte[] Picture { get; set; }

        public virtual ICollection<UserInformation> UserInformations { get; set; }


        //public virtual int DieticianRegisterInfoId { get; set; }
        public virtual DieticianRegisterInfo DieticianRegisterInfo { get; set; }
    }
}
