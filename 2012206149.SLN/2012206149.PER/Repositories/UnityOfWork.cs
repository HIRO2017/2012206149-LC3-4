using _2012206149.ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly _2012206149Context _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IClienteRepository Clientes { get; private set; }

        public IAdministrativoRepository Administrativos { get; private set; }

        public IBusRepository Buses { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IEncomiendaRepository Encomiendas { get; private set; }

        public ILugarViajeRepository LugarViajes { get; private set; }

        public IServicioRepository Servicios { get; private set; }

        public ITipoComprobanteRepository TipoComprobantes { get; private set; }

        public ITipoLugarRepository TipoLugares { get; private set; }

        public ITipoPagoRepository TipoPagos { get; private set; }

        public ITipoTripulacionRepository TipoTripulaciones { get; private set; }

        public ITipoViajeRepository TipoViajes { get; private set; }

        public ITransporteRepository Transportes { get; private set; }

        public ITripulacionRepository Tripulaciones { get; private set; }

        public IVentaRepository Ventas { get; private set; }


        private UnityOfWork()
        {
            _Context = new  _2012206149Context();


            Administrativos = new AdministrativoRepository(_Context);
            Buses = new BusRepository(_Context);          
            Clientes = new ClienteRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            Encomiendas = new EncomiendaRepository(_Context);
            LugarViajes = new LugarViajeRepository(_Context);
            Servicios = new ServicioRepository(_Context);
            TipoComprobantes = new TipoComprobanteRepository(_Context);
            TipoLugares = new TipoLugarRepository(_Context);
            TipoPagos = new TipoPagoRepository(_Context);
            TipoTripulaciones = new TipoTripulacionRepository(_Context);
            TipoViajes = new TipoViajeRepository(_Context);
            Transportes = new TransporteRepository(_Context);
            Tripulaciones = new TripulacionRepository(_Context);
            Ventas = new VentaRepository(_Context);



        }

        public static   UnityOfWork Instance
        {

            get
            {
                //variable de control
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }

        }
      

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
           return   _Context.SaveChanges();
           
        }

        public int saveChanges()
        {
            return Instance.saveChanges();
        }

        public void StateModified(object entity)
        {
            throw new NotImplementedException();
        }
    }
}
