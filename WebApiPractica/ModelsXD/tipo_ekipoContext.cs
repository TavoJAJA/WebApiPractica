using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebApiPractica.ModelsXD
{
    public class tipo_ekipoContext
    {
        public tipo_ekipoContext(DbContextOptions<tipo_ekipoContext> options) : base(options)
        {
        }

        public DbSet<tipo_equipo> tipo_equipo { get; set; }
    }
}
