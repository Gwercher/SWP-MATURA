namespace Models;

public class StockObserver2 : IObserver {
    private StockSubject? _subject;

    public decimal Price {get; set;}
    public void Update()
    {
        if(_subject != null){
            System.Console.WriteLine("Class " + GetType() + " has new price = " + Price);
            Price = _subject.Price;
        }
    }

    public StockObserver2() : this(null){}
    public StockObserver2(StockSubject? sub){
        if(sub != null){
            _subject = sub;
        }
    }

}