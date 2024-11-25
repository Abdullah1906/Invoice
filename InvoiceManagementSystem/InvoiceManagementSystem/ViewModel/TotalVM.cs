namespace InvoiceManagementSystem.ViewModel
{
    public class TotalVM
    {
        public double SubTotal { get; set; }
        public double VAT { get; set; }
        public double TotalVAT { get; set; }
        public double Total { get; set; }

        //for admin
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
