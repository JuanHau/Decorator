using Decorator.Entidades.Interfaces;
using Decorator.Servicios.Interfaces;
using System;

namespace Decorator.Servicios
{
    public class HistorialGuardadoCxP : BaseServiceCxP
    {
        public HistorialGuardadoCxP(IServiceCxP serviceCxP) : base(serviceCxP) { }

        public override void GuardarCxP(ICuentaPorPagar cuentaPorPagar)
        {
            _serviceCxP.GuardarCxP(cuentaPorPagar);
            Console.WriteLine(string.Format("Se ha guardado el historial de la CxP con identificador {0}", cuentaPorPagar.Id));
        }
    }
}
