using _2012206149.ENT.Entidades;
using _2012206149.ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.PER.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly _2012206149Context _Context;

        private ClienteRepository()
        {

        }

        public ClienteRepository(_2012206149Context context)
        {
            _Context = context;
        }

            

        IEnumerable<Cliente> IClienteRepository.GetClienteClassification(Servicio servicio)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Cliente> IClienteRepository.GetClienteWhit2012206149(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
