namespace BibliotecaApi.Services
{
using BibliotecaApi.Services;
    public class LibroService
    {
        private static List<Libro> _libros = new();

        public LibroService()
        {
            _libros = new List<Libro>
            {
                new Libro(1, "Título1", "Autor1", "1234", "Tema1"),
                new Libro(2, "Título2", "Autor2", "2345", "Tema2"),
                new Libro(3, "Título3", "Autor3", "3456", "Tema3")
            };
        }

        public IEnumerable<Libro> GetAll()
        {
            return _libros;
        }

        public Libro GetById(int id)
        {
            return _libros.FirstOrDefault(l => l.Id == id);
        }
    }