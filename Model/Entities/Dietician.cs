using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Dietician
    {
        public Dietician()
        {
            UserInformations = new HashSet<UserInformation>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Graduation { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<UserInformation> UserInformations { get; set; }

        //public virtual int DieticianRegisterInfoId { get; set; }
        public DieticianRegisterInfo DieticianRegisterInfo { get; set; }
    }
}
