using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class DieticianConfiguration : EntityTypeConfiguration<Dietician>
    {
        public DieticianConfiguration()
        {
            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.FirstName).IsRequired().HasMaxLength(50);
            Property(a => a.LastName).IsRequired().HasMaxLength(50);
            Property(a => a.Graduation).IsRequired().HasMaxLength(100);
            HasMany(a => a.UserInformations).WithRequired(a => a.Dietician).HasForeignKey(a => a.DieticianId);

            HasOptional(a => a.DieticianRegisterInfo).WithRequired(a => a.Dietician);
        }
    }
}
