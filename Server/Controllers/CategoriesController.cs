using MoviesProject.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MoviesProject.Server.Controllers
{
    [ApiController]
    /* El[controller] tomará el nombre del controlador, en este caso CategoryController */
    [Route("api/[controller]")]

    public class CategoriesController : ControllerBase
    {
        /* Los únicos métodos que reciben como parámetro la entidad son:
                [HttpPost] => POST(Add) => Crear registro
                [HttpPut] => PUT (Attach) => Actualizar registro   */
        /* El método que no recibe parámetro es:
                [HttpGet] => GET(ToListAsync) => Consultar historial de registros  */
        /* Los métodos que reciben como parámetro el Id son:
                [HttpDelete("{id}")] => DELETE (Remove) => Eliminar registro
                [HttpGet("{id}")] => GET[{id}] (FirstOrDefaultAsync) => Consultar por un registro específico*/

        private readonly ApplicationDbContext context;
        /* para crear el registro, se debe inyectar el DBContext en el controlador */
        public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]

        /* Devuelve un int correspondiente al id de la categoría */
        public async Task<ActionResult<int>> Post(Category category)
        {
            /* Método que agrega el registro a la BD */
            context.Add(category);
            /* Se aplican los cambios en la BD y se guardan de forma asíncrona */
            await context.SaveChangesAsync();
            return category.Id;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return await context.Categories.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            return await context.Categories.FirstOrDefaultAsync(x=>x.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Category category)
        {
            context.Attach(category).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id)
        {
            var exists = await context.Categories.AnyAsync(x=>x.Id == id);
            if (!exists)
            {
                return NotFound();
            }
            context.Remove(new Category {Id = id});
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}