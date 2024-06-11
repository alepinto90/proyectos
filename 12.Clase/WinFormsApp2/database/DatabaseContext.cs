using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using WinFormsApp2.models;

namespace WinFormsApp2.database
{
    public class DatabaseContext : DbContext 
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=.; Database=SistemaGestion1; Trusted_connection;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
