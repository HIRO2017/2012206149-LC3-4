using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IClienteRepository Clientes { get; }
        IAdministrativoRepository Administrativos { get; }
        IBusRepository Buses { get; }
        IEmpleadoRepository Empleados { get; }
        IEncomiendaRepository Encomiendas { get; }
        ILugarViajeRepository LugarViajes { get; }
        IServicioRepository Servicios { get; }
        ITipoComprobanteRepository TipoComprobantes { get; }
        ITipoLugarRepository TipoLugares { get; }
        ITipoPagoRepository TipoPagos { get; }
        ITipoTripulacionRepository TipoTripulaciones { get; }
        ITipoViajeRepository TipoViajes { get; }
        ITransporteRepository Transportes { get; }
        ITripulacionRepository Tripulaciones { get; }
        IVentaRepository Ventas { get; }


        //guarda cambios
        int saveChanges();

        void StateModified(object entity);

    }
}
