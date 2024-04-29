using System.ComponentModel.DataAnnotations;

namespace Models;

public class Address {
    [Key]
    public int Id {get; set;}
    public string PostalCode {get; set;}
    public string Street {get; set;}
    public string HouseNumber {get; set;}

    public Address() : this("STD POSTAL", "STD STREET", "STD HOUSENR"){}
    public Address(string postal, string street, string housNr){
        PostalCode = postal;
        Street = street;
        HouseNumber = housNr;
    }

    public override string ToString()
    {
        return "id=" + Id + ", postalCode=" + PostalCode + ", Street=" + Street + ", housrNr=" + HouseNumber;
    }

}