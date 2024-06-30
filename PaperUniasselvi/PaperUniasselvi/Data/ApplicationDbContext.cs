using Microsoft.EntityFrameworkCore;
using PaperUniasselvi.Models;

namespace PaperUniasselvi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base( options )
        {

        }

        public DbSet<CadastroDeEntidades> Entidades { get; set; }
    }
}
