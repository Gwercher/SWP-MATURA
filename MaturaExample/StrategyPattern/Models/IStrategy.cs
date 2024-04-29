namespace Models;

public interface IStrategy {
    bool SaveCustomerToDb(Customer customer);
}