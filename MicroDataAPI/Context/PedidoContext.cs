using MicroDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroDataAPI.Context
{
    public class PedidoContext : DbContext
    {
        public PedidoContext()
        {

        }
        public PedidoContext(DbContextOptions<PedidoContext> options) : base(options) 
        {

        }
        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-Q9E0R2E\\SQLEXPRESS; initial catalog = MicroDataDB; Integrated Security = true");
            }
           
        }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }

    }
}
