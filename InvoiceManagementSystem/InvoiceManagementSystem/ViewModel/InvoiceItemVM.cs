﻿namespace InvoiceManagementSystem
{
    public class InvoiceItemVM
    {
        public Guid InvoiceId { get; set; }
        public string? Description { get; set; }
        public double quantity { get; set; }
        public double ItemDiscount { get; set; }
        public string? discountType { get; set; }
        public double price { get; set; }
        public double TotalItem { get; set; }
        //for admin

        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
