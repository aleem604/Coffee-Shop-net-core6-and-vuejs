
using System.Collections.Generic;

namespace Coffee.Services {
    public interface IProductService {
        List<Coffee.Data.Product> GetAllProducts();
        Coffee.Data.Product GetProductById(int id);
        ServiceResponse<Coffee.Data.Product> CreateProduct(Coffee.Data.Product product);
        ServiceResponse<Coffee.Data.Product> ArchiveProduct(int id);
    }
}