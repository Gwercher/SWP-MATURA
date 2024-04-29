using System.ComponentModel.DataAnnotations;
using Models.DB;

namespace Models;

public class User {
    [Key]
    public int Id {get; set;}
    public string Name {get; set;}
    public DateTime Birthdate {get; set;}
    public Address Address {get; set;}
    public List<Newsletter> Newsletters {get; set;} = new List<Newsletter>();
    
    public User() : this("John Doe", DateTime.MinValue){}
    public User(string name, DateTime birthdate){
        Name = name;
        Birthdate = birthdate; 
    }

    public override string ToString()
    {
        string output = "id=" + Id + ", name=" + Name + ", birthdate=" + Birthdate.ToShortDateString();

        return output;
    }

}