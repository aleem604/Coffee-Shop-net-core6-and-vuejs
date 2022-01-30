using System;

namespace Coffee.Web.ViewModels {
    /// <summary>
    ///     Product entity DTO
    /// </summary>
    public class ProductModel {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsTaxable { get; set; } = false;
        public bool IsArchived { get; set; } = false;
    }
}