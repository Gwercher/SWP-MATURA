using System.ComponentModel.DataAnnotations;

namespace Models;

public class Newsletter {
    [Key]
    public int Id {get; set;}
    public string Name {get; set;}
    public string Website {get; set;}
    public List<User> Users {get; set;} = new List<User>();

    public Newsletter() : this("STD NEWSLETTER NAME", "STD.WEBSITE.DOM"){}
    public Newsletter(string name, string website){
        Name = name;
        Website = website;
    }

    public override string ToString()
    {
        return "id=" + Id + ", Name=" + Name + ", Website=" + Website;
    }
}