using _2012206149.ENT.Entidades;
using _2012206149.ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.PER.EntityTypeConfigurations
{
    public class AdministrativoConfiguration : EntityTypeConfiguration<Administrativo>
    {

        public AdministrativoConfiguration()
        {

            ToTable("Adminnistrativo");

            HasKey(c => c.AdminId);
        }

        
    }
}