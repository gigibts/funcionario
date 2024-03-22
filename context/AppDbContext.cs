using funcionario.Models;
using Microsoft.EntityFrameworkCore;

namespace funcionario.context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base (options)
    {
  }
  public DbSet<Funcionario> Funcionarios {get; set;}
  public DbSet<Setor> Setores {get; set;}

}
