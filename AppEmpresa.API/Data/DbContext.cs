using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppEmpresa.Entidades;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<AppEmpresa.Entidades.Cargo> Cargos { get; set; } = default!;
        public DbSet<AppEmpresa.Entidades.Departamento> Departamentos { get; set; } = default!;
        public DbSet<AppEmpresa.Entidades.Empleado> Empleados { get; set; } = default!;
    }
