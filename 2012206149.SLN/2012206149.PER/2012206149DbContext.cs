using _2012206149.ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.PER
{
    public class _2012206149DbContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}
