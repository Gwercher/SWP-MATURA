using Microsoft.EntityFrameworkCore;

namespace Models.DB;

public class OrmContext : DbContext {
    
    public DbSet<User> Users {get; set;}
    public DbSet<Address> Addresses {get; set;}
    public DbSet<Newsletter> Newsletters {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string con = "Server=localhost;database=swp_matura_orm;user=root;password=qav2Sd9V";

        optionsBuilder.UseMySql(con, ServerVersion.AutoDetect(con));

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