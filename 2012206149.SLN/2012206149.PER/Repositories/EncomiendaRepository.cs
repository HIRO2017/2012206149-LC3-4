﻿using _2012206149.ENT.Entidades;
using _2012206149.ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.PER.Repositories
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {
        private _2012206149Context _Context;

        public EncomiendaRepository(_2012206149Context context)
        {
            _Context = context;
        }
    }
}
