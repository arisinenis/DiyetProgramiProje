using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public string MessageHeader { get; set; }
        public string Text { get; set; }

        public virtual int UserInformationId { get; set; }
        public virtual UserInformation UserInformation { get; set; }
    }
}
