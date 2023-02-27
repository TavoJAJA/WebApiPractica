﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace WebApiPractica.ModelsXD
{
    public class equiposContext : DbContext 
    {
        public equiposContext (DbContextOptions<equiposContext>options) : base(options) 
        {
        }

        public DbSet<equipos> equipos { get; set; } 
    }
}
