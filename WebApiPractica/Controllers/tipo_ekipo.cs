using Microsoft.AspNetCore.Http;
using WebApiPractica.ModelsXD;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;

namespace WebApiPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class tipo_equipo : ControllerBase
    {
        private readonly tipo_equipo _tipo_equipo;

    }
    public tipo_ekipo(tipo_ekipoContext tipo_ekipoContext)

    {
        _tipo_equipo = tipo_ekipoContexto;
    }

    [HttpGet]
    [Route("GetAll")]
    public IActionsResult Get()
    {
        List<tipo_equipo> tipo_equipo = (from e in tipo_ekipoContext._tipo_equipo select e).ToList();

        if (tipo_equipo.Count() = 0)
        {
            return NotFound();
        }

        return Ok(tipo_equipo);
    }

    [HttpGet]
    [Route("GetById/{id}")]

    public IActionsResult Get(int id)
    {
        tipo_equipo? tipo_ekipo = (from e in tipo_ekipoContext._tipo_equipo
                                   where e.tipo_ekipo == id
                                   select e).FirstOrDefault();

        if (tipo_equipo == null)
        {
            return NotFound();

        }
        return Ok(tipo_equipo);
    }

    [HttpPost]
    [Route("Add")]

    public IActionResult Guardartipo_ekipos([FromBody] tipo_equipo tipo_Equipo)
    {
        try
        {
            tipo_ekipoContexto.marcas.Add(tipo_Equipo);
            tipo_ekipoContexto.SaveChanges();
            return Ok(tipo_Equipo);
        }

        catch (Exception ex)
        {
            return BadRequest(Exception.Messages);
        }
    }

    [HttpPut]
    [Route("actualizar/{id}")]

    public IActionResult ActualizartipoEquipo(int id, [FromBody] tipo_equipo modificarTipoEquipo)
    {
        tipo_equipo? tipoEquipoActual = (from e in tipo_ekipoContext.tipo_equipo
                                where e.id_equipos == id
                                select e).FirstOrDefault();
        if tipoEquipoActual == null)
        { return NotFound(); }.

            tipoEquipoActual.tipo_ekipo = modificarTipoEquipo.tipo_ekipo;
            tipoEquipoActual.descripcion = modificarTipoEquipo.descripcion;
        tipoEquipoActual.estado = modificarTipoEquipo.estado;

        tipo_ekipoContext.Entry(tipoEquipoActual).State = EntityState.Modified;
        tipo_ekipoContextSaveChanges();

        return Ok(modificarTipoEquipo);
    }

    [HttpDelete]
    [Route("eliminar/{id}")]
    public IActionsResult EliminartipoEquipo(int id)
    {
        marcas? marcas = (from e in tipo_ekipoContext.tipo_equipo
                          where e.id_marcas == id
                          select e).FirstOrDefault();

        if (marcas == null)
            return NotFound();

        tipo_ekipoContext.tipo_equipo.Attach(tipo_equipo;
        tipo_ekipoContext.tipo_equipo.Remove(tipo_equipo);
        tipo_ekipoContext.SaveChanges();

        return Ok(tipo_equipo);
    }
}