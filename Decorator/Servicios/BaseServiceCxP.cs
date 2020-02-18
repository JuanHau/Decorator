using Decorator.Entidades.Interfaces;
using Decorator.Servicios.Interfaces;

namespace Decorator.Servicios
{
    public abstract class BaseServiceCxP : IServiceCxP
    {
        protected IServiceCxP _serviceCxP;

        protected BaseServiceCxP(IServiceCxP serviceCxP)
        {
            _serviceCxP = serviceCxP;
        }

        public void EstablecerServicio(IServiceCxP serviceCxP)
        {
            _serviceCxP = serviceCxP;
        }

        public abstract void GuardarCxP(ICuentaPorPagar cuentaPorPagar);
    }
}
