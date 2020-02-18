namespace Decorator.Entidades.Interfaces
{
    public interface ICuentaPorPagar
    {
        public string Id { get; set; }
        public double Importe { get; set; }
        public string Descripcion { get; set; }
    }
}
