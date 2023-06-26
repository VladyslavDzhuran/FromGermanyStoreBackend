using FromGermanyStoreDataAccessLibrary.Enums;
using System.ComponentModel.DataAnnotations;

namespace FromGermanyStoreBackend.Requests
{
    public class ProductItemRequest
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public Categories Category { get; set; }
    }
}
