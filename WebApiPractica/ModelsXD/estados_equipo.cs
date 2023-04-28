using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
namespace WebApiPractica.ModelsXD
{
    public class estados_equipo
    {
        public int id_estados { get; set; }

        public string descripcion { get; set; }

        public string estado { get; set;}

    }
}
