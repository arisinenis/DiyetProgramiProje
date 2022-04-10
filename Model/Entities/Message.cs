using Model.Abstract;
using Model.Enums;
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
        public int DieticianId { get; set; }
        public string MessageHeader { get; set; }
        public string Text { get; set; }
        public StatusEnum Status { get; set; } = StatusEnum.Active;
        public DateTime MessageDate { get; set; } = DateTime.Now;

        public virtual int UserInformationId { get; set; }
        public virtual UserInformation UserInformation { get; set; }
    }
}
