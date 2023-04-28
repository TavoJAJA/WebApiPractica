using Microsoft.AspNetCore.Http;
using WebApiPractica.ModelsXD;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;

namespace WebApiPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class estadosEquipoController : ControllerBase
    {
        private readonly estadosEquipoController _estadosEquipoControllero;

    }
    public estados_equipo(estadoEquipoContext _estadosEquipoControllero)

    {
        estados_equipo = _estadosEquipoControllero;
    }

    [HttpGet]
    [Route("GetAll")]
    public IActionsResult Get()
    {
        List<estados_equipo> estados_equipo = (from e in tipo_ekipoContext.estados_equipo select e).ToList();

        if estados_equipo.Count() = 0)
        {
            return NotFound();
        }

        return Ok(estados_equipo);
    }

    [HttpGet]
    [Route("GetById/{id}")]

    public IActionsResult Get(int id)
    {
        estados_equipo? estados_Equipo = (from e in _estadosEquipoControllero.estados_equipo
                                          where e.tipo_ekipo == id
                                          select e).FirstOrDefault();

        if (estados_equipo == null)
        {
            return NotFound();

        }
        return Ok(estados_equipo);
    }

    [HttpPost]
    [Route("Add")]

    public IActionResult Guardarestados_equipo([FromBody] estados_equipo estados_equipo)
    {
        try
        {
            _estadosEquipoControllero.estado_equipo.Add(estado_equipo);
            _estadosEquipoControllero.SaveChanges();
            return Ok(estado_equipo);
        }

        catch (Exception ex)
        {
            return BadRequest(Exception.Messages);
        }
    }

    [HttpPut]
    [Route("actualizar/{id}")]

    public IActionResult ActualizartipoEquipo(int id, [FromBody] estado_equipo modificarEstadoEquipo)
    {
        estado_equipo? estado_equipoActual = (from e in estadoEquipoContext._estadosEquipoControllero
                                              where e.id_equipos == id
                                              select e).FirstOrDefault();
        if estado_equipoActual == null)
        { return NotFound(); }.

            estado_equipoActual.id_estados = modificarEstadoEquipo.id_estados;
            estado_equipoActual.descripcion = modificarEstadoEquipo.descripcion;
            estado_equipoActual.estado = modificarEstadoEquipo.estado;

        estadoEquipoContext.Entry(estado_equipoActual).State = EntityState.Modified;
        estadoEquipoContext.SaveChanges();

        return Ok(modificarEstadoEquipo);
    }

    [HttpDelete]
    [Route("eliminar/{id}")]
    public IActionsResult EliminarestadoEquipo(int id)
    {
        marcas? marcas = (from e in estadosEquipoContext.tipo_equipo
                          where e.id_marcas == id
                          select e).FirstOrDefault();

        if (marcas == null)
            return NotFound();

        estadosEquipoContext.tipo_equipo.Attach(estados_equipo);
        estadosEquipoContext.tipo_equipo.Remove(estados_equipo);
        estadosEquipoContext.SaveChanges();

        return Ok(estados_equipo);
    }
}
