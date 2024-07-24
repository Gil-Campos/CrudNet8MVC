using Microsoft.EntityFrameworkCore;
using ProyectoCrudNet8MVC.Models;

namespace ProyectoCrudNet8MVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    // Add models here, each model its related to a table in teh database
    public DbSet<Contact> Contact { get; set; }
}