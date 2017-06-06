using _2012206149.ENT;
using _2012206149.ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.PER
{
    public class _2012206149Context : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.Venta> Ventas { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.Bus> Buses { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.Encomienda> Encomiendas { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.LugarViaje> LugarViajes { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.Servicio> Servicios { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.TipoLugar> TipoLugars { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.TipoPago> TipoPagoes { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.Transporte> Transportes { get; set; }

        public System.Data.Entity.DbSet<_2012206149.ENT.Entidades.Tripulacion> Tripulacions { get; set; }
    }
}
