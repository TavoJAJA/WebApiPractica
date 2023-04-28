using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApiPractica.ModelsXD
{
    public class marcas
    {
        [Key]
        public int id_marcas { get; set; }
        public string nombre_marca { get; set; }
        public string estados { get; set; }

        [Display(Name ="ID")]
        public int id_marcas { get; set; }
        [Display(Name = "Nombre de la marca")]

        public string? estados { get; set; }
    }
}
