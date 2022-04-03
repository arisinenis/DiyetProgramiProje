using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class DieticianMessage:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MessageHeader { get; set; }
        public string Text { get; set; }
        public string Status { get; set; } = "Active";
        public DateTime MessageDate { get; set; } = DateTime.Now;

        public virtual int DieticianId { get; set; }
        public virtual Dietician Dietician { get; set; }
    }
}
