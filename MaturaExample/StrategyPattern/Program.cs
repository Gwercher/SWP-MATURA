using Models;

namespace StrategyPattern{
    public class Program {
        public static void Main(string[] args){
            IStrategy? strategy = null;
            Customer c = new Customer(1, "John Doe");
            
            System.Console.WriteLine("Choose which DB to use!");
            System.Console.WriteLine("1 ... MySql");
            System.Console.WriteLine("2 ... Oracle");
            string? choice = Console.ReadLine();

            switch(choice){
                case "1":
                    strategy = new MySqlStrategy();
                break;
                case "2":
                    strategy = new OracleStrategy();
                break;
                default:
                    System.Console.WriteLine("incorrect input");
                break;
            }

            if(strategy != null){
                strategy.SaveCustomerToDb(c);
            }
        }
    }
}