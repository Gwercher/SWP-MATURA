using Microsoft.EntityFrameworkCore;

namespace Models.DB;

public class WebsiteContext : DbContext {

    // public DbSet<Class> Classes {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string con = "Server=localhost;database=swp_matura_dotnet;user=root;password=qav2Sd9V";

        optionsBuilder.UseMySql(con, ServerVersion.AutoDetect(con));

    }
}