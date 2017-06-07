using _2012206149.ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.PER.EntityTypeConfigurations
{
    public class TipoViajeConfiguration : EntityTypeConfiguration<TipoViaje>
    {
        public TipoViajeConfiguration()
        {

            ToTable("TipoViaje");

            HasKey(c => c.tipoViajeId);
        }
    }
}