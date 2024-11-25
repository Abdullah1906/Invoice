namespace InvoiceManagementSystem.ViewModel
{
    public class CustomerVM
    {
        public string? Name { get; set; }
        public string? Number { get; set; }
        public string? Address { get; set; }

        public double Discount { get; set; }
        public double Total { get; set; }
        // for admin
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
    }
    public class MultiModelVM
    {
        public CustomerVM? Customer { get; set; }
        
        public InvoiceVM? Invoice { get; set; }
        public List<InvoiceItemVM>? InvoiceItem { get; set; }

    }
    public class InvoiceItemVM
    {
        public Guid InvoiceId { get; set; }
        public string? Description { get; set; }
        public double quantity { get; set; }
        public double price { get; set; }
        public double TotalItem { get; set; }



    }

}
