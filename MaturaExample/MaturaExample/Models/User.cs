using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class User {
    [Key]
    public string? Email {get; set;}
    public string? Password {get; set;}
    [NotMapped]
    public string? PasswordRetype {get; set;}
    public DateTime Birthdate {get; set;}
    public Role Role {get; set;} = Role.Default;
}