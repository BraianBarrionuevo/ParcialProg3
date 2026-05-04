namespace Restaurante
{
    public abstract class Plato
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Plato(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public abstract void Preparar();
    }
}