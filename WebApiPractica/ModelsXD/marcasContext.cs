using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace WebApiPractica.ModelsXD
{
    public class marcasContext
    {
        public marcasContext(DbContextOptions<marcasContext> options) : base(options)
        {
        }

        public DbSet<marcas> marcas { get; set; }
    }
}
