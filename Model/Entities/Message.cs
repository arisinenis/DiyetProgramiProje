using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public virtual int UserInformationId { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
