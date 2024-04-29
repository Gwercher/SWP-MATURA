namespace Models;

public class OracleStrategy : IStrategy
{
    public bool SaveCustomerToDb(Customer customer)
    {
        System.Console.WriteLine("Saving User(" + customer.ToString() + ") to Oracle");
        return OracleConnector.SaveCustomerToOracle(customer);
    }
}