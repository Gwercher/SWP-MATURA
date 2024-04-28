using Microsoft.EntityFrameworkCore;

namespace Models.DB;

public class WebsiteContext : DbContext {

    public DbSet<User> Users {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string con = "Server=localhost;database=swp_matura_dotnet;user=root;password=qav2Sd9V";

        optionsBuilder.UseMySql(con, ServerVersion.AutoDetect(con));

    }

    protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<User>().HasIndex(u => u.Email).IsUnique();
    }

    public async Task SaveToDbAsync(){
        try {
            await SaveChangesAsync();
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
        }
    } 
}