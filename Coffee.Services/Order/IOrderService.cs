using System.Collections.Generic;
using Coffee.Data;

namespace Coffee.Services {
    public interface IOrderService {
        List<SalesOrder> GetOrders();
        ServiceResponse<bool> GenerateOpenOrder(SalesOrder order);
        ServiceResponse<bool> MarkFulfilled(int id);
    }
}