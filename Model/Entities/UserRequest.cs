using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class UserRequest
    {
        public UserRequest()
        {
            UserInformations = new HashSet<UserInformation>();
        }
        public int Id { get; set; }
        public UserRequestsEnum Description { get; set; }

        public virtual ICollection<UserInformation> UserInformations { get; set; }
    }
}
