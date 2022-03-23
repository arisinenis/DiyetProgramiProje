using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class MessageConfiguration 
        : EntityTypeConfiguration<Message>
    {
        public MessageConfiguration()
        {
            Property(m => m.MessageHeader).IsRequired();
            Property(m => m.Text).IsRequired();

            HasRequired(m => m.UserInformation).WithMany(m => m.Messages).HasForeignKey(m => m.UserInformationId);
        }
    }
}
