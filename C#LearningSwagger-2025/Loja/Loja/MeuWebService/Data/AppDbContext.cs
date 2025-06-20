using Microsoft.EntityFrameworkCore;
using Loja.Models;

namespace Loja.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<MoradaCliente> MoradasClientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacionamento entre Produtos e CategoriaProduto
            modelBuilder.Entity<Produto>()
                .ToTable("Produto")
                .HasOne(p => p.CategoriaProduto)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaProdutoId);

            modelBuilder.Entity<CategoriaProduto>().ToTable("CategoriaProduto");

            modelBuilder.Entity<MoradaCliente>().ToTable("MoradaCliente");

            // Relacionamento entre Clientes e MoradaCliente
            modelBuilder.Entity<Clientes>()
                .HasOne(c => c.MoradaCliente)
                .WithMany(m => m.Clientes)
                .HasForeignKey(c => c.MoradaClienteId);

            modelBuilder.Entity<Clientes>().ToTable("Clientes");
        }
    }
}
