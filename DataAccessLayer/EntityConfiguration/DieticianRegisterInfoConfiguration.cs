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
    public class DieticianRegisterInfoConfiguration : EntityTypeConfiguration<DieticianRegisterInfo>
    {
        public DieticianRegisterInfoConfiguration()
        {
            //Property(dr => dr.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(dr => dr.Email).IsRequired().HasMaxLength(100);
            Property(dr => dr.Password).IsRequired();
            Property(dr => dr.UserType).IsRequired();

            HasIndex(dr => dr.Email).IsUnique();
        }
    }
}
