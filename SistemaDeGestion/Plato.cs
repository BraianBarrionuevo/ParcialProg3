namespace Restaurante
{
    public abstract class Plato
    {

        private string _nombre { get; }
        private string _idPlato { get; }

        private string _categoria;
        public string Categoria
        {

            get => _categoria;

            set
            {

                if (_categoria == null) throw new ArgumentNullException("La categoria no puede ser null");
    

            _categoria = value;

            }

        }


        public int Anio {get; set;}

        public Plato(string nombre, string idPlato, string categoria, int anio)
        {
            _nombre = nombre;
            _idPlato = idPlato;
            _categoria = categoria;
            Anio = anio;
        }

    
    
    }
}