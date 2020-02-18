using Decorator.Entidades.Interfaces;
using Decorator.Servicios.Interfaces;
using System;

namespace Decorator.Servicios
{
    public class NotificacionCxP : BaseServiceCxP
    {
        public NotificacionCxP(IServiceCxP serviceCxP) : base(serviceCxP) { }

        public override void GuardarCxP(ICuentaPorPagar cuentaPorPagar)
        {
            _serviceCxP.GuardarCxP(cuentaPorPagar);
            Console.WriteLine("Se ha enviado un correo de notificación");
            Console.WriteLine();
        }
    }
}
