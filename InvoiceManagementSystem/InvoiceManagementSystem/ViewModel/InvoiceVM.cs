namespace InvoiceManagementSystem.ViewModel
{
    public class InvoiceVM
    {
        public Guid CustomerId { get; set; }
        public string? number { get; set; }
        public string? HolderName { get; set; }
        public DateTime Date { get; set; }

        // for admin

        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
