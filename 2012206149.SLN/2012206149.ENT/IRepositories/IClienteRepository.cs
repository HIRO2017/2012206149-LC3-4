using _2012206149.ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.ENT.IRepositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        //registro
        IEnumerable<Cliente> GetClienteWhit2012206149(int pageIndex, int pageSize);

        //relacion de actor con el servicio obtenido
        IEnumerable<Cliente> GetClienteClassification(Servicio servicio );
    }
}
