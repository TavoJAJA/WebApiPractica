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
}
