using Decorator.Entidades.Interfaces;
using Decorator.Servicios.Interfaces;
using System;

namespace Decorator.Servicios
{
    public class DefaultServiceCxP : IServiceCxP
    {
        public void GuardarCxP(ICuentaPorPagar cuentaPorPagar)
        {
            Console.WriteLine(string.Format("Se ha guardado correctamente la CxP con identificado " +
                "{0} con un monto de {1} bajo la descripción: {2}", 
                cuentaPorPagar.Id, cuentaPorPagar.Importe, cuentaPorPagar.Descripcion));
        }
    }
}
