using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    internal class DieticianMessageConfiguration:EntityTypeConfiguration<DieticianMessage>
    {
        public DieticianMessageConfiguration()
        {
            Property(m => m.MessageHeader).IsRequired();
            Property(m => m.Text).IsRequired();
            Property(m => m.MessageDate).IsRequired();
            Property(m => m.UserId).IsRequired();


            HasRequired(m => m.Dietician).WithMany(m => m.DieticianMessages).HasForeignKey(m => m.DieticianId);
        }
    }
}
