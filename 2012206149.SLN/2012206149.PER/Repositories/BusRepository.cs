using _2012206149.ENT.Entidades;
using _2012206149.ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.PER.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        private _2012206149Context _Context;

        public BusRepository(_2012206149Context context)
        {
            _Context = context;
        }
    }
}
