using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ControleSalasPortal.EF;

namespace ControleSalasPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ControleSalasPortal.EF.Alunos> Alunos { get; set; }
        public DbSet<ControleSalasPortal.EF.Datas> Datas { get; set; }
        public DbSet<ControleSalasPortal.EF.Professor> Professor { get; set; }
        public DbSet<ControleSalasPortal.EF.Salas> Salas { get; set; }
        public DbSet<ControleSalasPortal.EF.Turmas> Turmas { get; set; }
    }
}
