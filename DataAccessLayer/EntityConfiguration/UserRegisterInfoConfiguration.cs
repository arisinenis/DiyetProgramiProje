using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class UserRegisterInfoConfiguration 
        : EntityTypeConfiguration<UserRegisterInfo>
    {
        public UserRegisterInfoConfiguration()
        {
            Property(u => u.Email).IsRequired().HasMaxLength(50);
            Property(u => u.Password).IsRequired().HasMaxLength(20);
            Property(u => u.UserType).IsRequired();
        }
    }
}
