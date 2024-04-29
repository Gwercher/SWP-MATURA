using Models;

namespace Models;

public class MySqlStrategy : IStrategy
{
    public bool SaveCustomerToDb(Customer customer)
    {
        System.Console.WriteLine("Saving User(" + customer.ToString() + ") to MySql");
        return MySqlConnector.SaveCustomerToMySql(customer);
    }
}