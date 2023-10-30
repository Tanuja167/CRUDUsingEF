using CRUDUsingEF.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDUsingEF.Data
{

    //child class to get features of Dbcontext class
    public class ApplicationDbContext : DbContext
    {

        // DbContextOptions is used for Configuration --> connection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>op) : base(op)
        {

        }
        public DbSet<Book> Books { get; set; }

       

    }
}
