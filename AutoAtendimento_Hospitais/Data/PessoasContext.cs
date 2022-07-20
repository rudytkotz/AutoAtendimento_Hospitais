using AutoAtendimento_Hospitais.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoAtendimento_Hospitais.Data
{
    public class PessoasContext : DbContext
    {
        public PessoasContext(DbContextOptions<PessoasContext> opt) : base(opt)
        {
            
        }

        public DbSet<Paciente> Pacientes { get; set; } 
    }
}
