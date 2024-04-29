namespace Models;

public class StockObserver1 : IObserver {
    private StockSubject? _subject;

    public decimal Price {get; set;}
    public void Update()
    {
        if(_subject != null){
            System.Console.WriteLine("Class " + GetType() + " has new price = " + Price);
            Price = _subject.Price;
        }
    }

    public StockObserver1() : this(null){}
    public StockObserver1(StockSubject? sub){
        if(sub != null){
            _subject = sub;
        }
    }

}