using Model.Entities;
using System;
using System.Collections.Generic;
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
            Property(dr => dr.Email).IsRequired();
            Property(dr => dr.Password).IsRequired();
            Property(dr => dr.UserType).IsRequired();
        }
    }
}
