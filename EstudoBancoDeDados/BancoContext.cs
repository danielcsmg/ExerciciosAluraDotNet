using EstudoBancoDeDados.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoBancoDeDados;
public class BancoContext : DbContext
{
    public BancoContext() { }
    public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Promocao> Promocoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<PromocaoProduto>()
            .HasKey(pp => new {pp.PromocaoId, pp.ProdutoId});
        base.OnModelCreating(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}
