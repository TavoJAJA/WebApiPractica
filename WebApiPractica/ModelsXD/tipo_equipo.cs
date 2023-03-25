using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace WebApiPractica.ModelsXD
{
    public class tipo_equipo
    {

        public int tipo_ekipo { get; set; }

        public string descripcion { get; set; }

        public string estado { get; set; }

    }
}
