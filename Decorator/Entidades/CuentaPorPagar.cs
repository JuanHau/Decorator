using Decorator.Entidades.Interfaces;

namespace Decorator.Entidades
{
    public class CuentaPorPagar : ICuentaPorPagar
    {
        public string Id { get; set; }
        public double Importe { get; set; }
        public string Descripcion { get; set; }
    }
}
