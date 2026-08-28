using Microsoft.AspNetCore.Mvc;
using BibliotecaApi.models;

namespace BibliotecaApi.controllers;
[ApiController] //indica que esta es la clase controlador de la api
[Route("api/[controller]")] //para acceder a los distintos controladores de la api
public class LibrosController : ControllerBase
{
    private static List<Libro> _libros = new()
    {
        new Libro(1, "Título1", "Autor1", "1234", "Tema1"),
        new Libro(2, "Título2", "Autor2", "2345", "Tema2"),
        new Libro(3, "Título3", "Autor3", "3456", "Tema3")
    };
    [HttpGet] 
    public ActionResult<IEnumerable<Libro>> GetAll()
    {
        return Ok(_libros);
    }
    [HttpGet("{id}")]
    public ActionResult<Libro> GetById(int id)
    {
        Libro libro = _libros.FirstOrDefault(l => l.Id == id);
        if(libro != null)
        {
            return Ok(libro);
        } 
        else return NotFound("Libro no encontrado!!!");
    }
}