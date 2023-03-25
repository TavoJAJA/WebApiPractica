using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace WebApiPractica.ModelsXD
{
    public class marcas
    {
        [key]
        public int id_marcas { get; set; }
        public string nombre_marca { get; set; }
        public string estados { get; set; }

    }
}
