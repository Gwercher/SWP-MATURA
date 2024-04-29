using Models;

namespace ObserverPattern{
    public class Program {
        public static void Main(string[] args){
            
            StockSubject sub = new StockSubject();

            StockObserver1 obs1 = new StockObserver1(sub);
            StockObserver2 obs2 = new StockObserver2(sub);

            sub.Register(obs1);
            sub.Register(obs2);

            sub.Price = 50.0m;
            Thread.Sleep(1000);
            sub.Price = 100m;
            Thread.Sleep(1500);
            sub.Price = 100m;
            Thread.Sleep(2000);
            sub.Price = 75.5m;
        }
    }
}