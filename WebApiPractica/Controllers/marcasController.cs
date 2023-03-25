using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPractica.ModelsXD;
using Microsoft.EntityFrameworkCore;
namespace WebApiPractica.Controllers
{
    public class marcasController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class marcasControllerr : ControllerBase
        {
            private readonly marcasContext _contextoMarcas ;

        }

        public marcasController(marcasContext marcasContext)
        {
            _contextoMarcas = marcasContext;
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionsResult Get()
        {
            List<marcas> listadoMarcas = (from e in _contextoMarcas.marcas select e).ToList();

            if (ListadoMarcas.Count() = 0)
            {
                return NotFound();
            }

            return Ok(ListadoMarcas);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionsResult Get(int id)
        {
            marcas? marcas = (from e in _contextoMarcas.marcas
                               where e.id_marcas == id
                               select e).FirstOrDefault();

            if (marcas == null)
            {
                return NotFound();

            }
            return Ok(marcas);
        }

        [HttpPost]
        [Route("Add")]

        public IActionResult GuardarMarcas([FromBody] marcas marcas)
        {
            try
            {
                _contextoMarcas.marcas.Add(marcas);
                _contextoMarcas.SaveChanges();
                return Ok(marcas);
            }

            catch (Exception ex)
            {
                retunr BadRequest(Exception.Messages);
            }
        }

        [HttpPut]
        [Route("actualizar/{id}")]

        public IActionResult ActualizarMarcas(int id, [FromBody] marcas marcasModificar)
        {
            equipos? marcaActual = (from e in _contextoMarcas.marcas
                                     where e.id_equipos == id
                                     select e).FirstOrDefault();
            if marcaActual == null)
            { return NotFound(); }.

            marcaActual.nombre_marca = marcasModificar.nombre_marca;
            marcaActual.estados = marcasModificar.estados;
            marcaActual.marca_id = marcasModificar.marca_id

            _contextoMarcas.Entry(marcaActual).State = EntityState.Modified;
            _contextoMarcas.SaveChanges();

            return Ok(marcasModificar);
        }

        [HttpDelete]
        [Route("eliminar/{id}")]

        public IActionsResult EliminarEquipo(int id)
        {
            marcas? marcas = (from e in _contextoMarcas.marcas
                               where e.id_marcas == id
                               select e).FirstOrDefault();

            if (marcas == null)
                return NotFound();

            _contextoMarcas.marcas.Attach(marcas);
            _contextoMarcas.marcas.Remove(marcas);
            _contextoMarcas.SaveChanges();

            return Ok(marcas);
        }


    }
}
