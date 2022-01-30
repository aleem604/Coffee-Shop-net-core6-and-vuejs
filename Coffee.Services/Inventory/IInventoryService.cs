using System.Collections.Generic;
using Coffee.Data;

namespace Coffee.Services {
    public interface IInventoryService {
        public List<ProductInventory> GetCurrentInventory();
        public ServiceResponse<ProductInventory> UpdateUnitsAvailable(int id, int adjustment);
        public ProductInventory GetByProductId(int productId);
        public List<ProductInventorySnapshot> GetSnapshotHistory();
    }
}