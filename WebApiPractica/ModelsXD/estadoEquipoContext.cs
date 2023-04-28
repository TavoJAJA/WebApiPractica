using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace WebApiPractica.ModelsXD
{
    public class estadoEquipoContext
    {
        public estadoEquipoContext(DbContextOptions<estadoEquipoContex> options) : base(options)
        {
        }

        public DbSet<estadoEquipoContex> estadoEquipoContex { get; set; }
    }
}
}
