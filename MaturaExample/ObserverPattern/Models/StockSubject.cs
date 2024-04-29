using Models;

namespace Models;

public class StockSubject : AbstractSubject {

    public string Name {get; set;}

    private decimal _price;

    public decimal Price {
        get {return _price;}
        set {
            if(_price != value){
                _price = value;
                Notify();
            }
        }
    }

    public StockSubject() : this("NA", 0.0m){}
    public StockSubject(string name, decimal price){
        Name = name;
        Price = price;
    }

}