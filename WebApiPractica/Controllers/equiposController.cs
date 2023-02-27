using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPractica.ModelsXD;
using Microsoft.EntityFrameworkCore;

namespace WebApiPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

    }

    public equiposController(equiposContext equiposContexto) 
    {
        _equiposContexto = equiposContexto;
    }

    [HttpGet]
    [Route("GetAll")]

    public IActionsResult Get() 
    {
        List<equipos> listadoEquipo = (from e in _equiposContexto.equipos select e).ToList();

        if (ListadoEquipo.Count() =0) 
        {
            return NotFound();
        }

        return Ok(listadoEquipo);
    }

    public IActionsResult Get() 
    {
        List<equipos> listadoEquipo = (from e in _equiposContexto.equipos select e).ToList();

        if (listadoEquipo.Count() == 0) 
        {
            return NotFound();
        }

        return Ok(listadoEquipo);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public IActionsResult Get(int id) 
    {
        equipos? equipo = (from e in _equiposContexto.equipos
                           where e.id_equipos == id
                           select e).FirstOrDefault();

        if (equipo == null) 
        {
            return NotFound();

        }
        return Ok(equipo);
    }

    [HttpPost]
    [Route("Add")]

    public IActionResult GuardarEquipo([FromBody] equipos equipo) 
    {
        try 
        {
            _equiposContexto.equipos.Add(equipo);
            _equiposContexto.SaveChanges();
            return Ok(equipo);
        }

        catch (Exception ex)
        {
            retunr BadRequest(Exception.Messages);
        }
    }

    [HttpPut]
    [Route("actualizar/{id}")]
    
    public IActionResult ActualizarEquipo (int id, [FromBody] equipos equipoModificar) 
    {
        equipos? equipoActual = (from e in _equiposContexto.equipos
                                 where e.id_equipos == id
                                 select e).FirstOrDefault();
        if (equipoActual == null) 
        {return NotFound();}.

        equipoActual.nombre = equipoModificar.nombre;
        equipoActual.descripcion = equipoModificar.descripcion;
        equipoActual.marca_id = equipoModificar.marca_id;
        equipoModificar.tipo_equipo_id = equipoModificar.tipo_equipo_id;
        equipoActual.anio_compra = equipoModificar.anio_compra;
        equipoActual.costo = equipoModificar.costo;

        _equiposContexto.Entry(equipoActual).State = EntityState.Modified;
        _equiposContexto.SaveChanges();

        return Ok(equipoModificar);
    }

    [HttpDelete]
    [Route("eliminar/{id}")]

    public IActionsResult EliminarEquipo (int id) 
    {
        equipos? equipo = (from e in _equiposContexto.equipos
                           where e.id_equipos == id
                           select e).FirstOrDefault();

        if (equipo == null)
            return NotFound();

        _equiposContexto.equipos.Attach(equipo);
        _equiposContexto.equipos.Remove(equipo);
        _equiposContexto.SaveChanges();

        return Ok(equipo);
    }

}
