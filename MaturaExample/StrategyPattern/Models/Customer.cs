namespace Models;

public class Customer {
    public int Id {get; set;}
    public string Name {get; set;}

    public Customer() : this(-1, "NA"){}
    public Customer(int id, string name){
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return "Id=" + Id + ", Name=" + Name;
    }
}