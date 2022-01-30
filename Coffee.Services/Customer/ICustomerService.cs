using System.Collections.Generic;

namespace Coffee.Services {
    public interface ICustomerService {
        List<Data.Customer> GetAllCustomers();
        ServiceResponse<Data.Customer> CreateCustomer(Data.Customer customer);
        ServiceResponse<bool> DeleteCustomer(int id);
        Data.Customer GetById(int id);
    }
}