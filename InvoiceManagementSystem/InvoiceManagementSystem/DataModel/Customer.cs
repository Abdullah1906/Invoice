using System.ComponentModel.DataAnnotations;

namespace InvoiceManagementSystem.DataModel
{
    public class Customer
    {
        [Key]
        public string? Name { get; set; }
        public string? Number { get; set; }
        public string? Address { get; set; }

        //for admin

        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
