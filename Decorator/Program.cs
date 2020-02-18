using Decorator.Entidades;
using Decorator.Servicios;
using System;

namespace Decorator
{
    public static class Program
    {
        static void Main(string[] args)
        {
            CuentaPorPagar cuentaPorPagar = new CuentaPorPagar()
            {
                Id = Guid.NewGuid().ToString(),
                Importe = 3726.22,
                Descripcion = "Alguna descripción de la CxP"
            };

            DefaultServiceCxP defaultServiceCxP = new DefaultServiceCxP();
            HistorialGuardadoCxP historialGuardadoCxP = new HistorialGuardadoCxP(defaultServiceCxP);
            NotificacionCxP notificacionCxP = new NotificacionCxP(historialGuardadoCxP);

            notificacionCxP.GuardarCxP(cuentaPorPagar);

            Console.ReadLine();
        }
    }
}
