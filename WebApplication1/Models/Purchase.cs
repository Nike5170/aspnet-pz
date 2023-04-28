using System;

namespace WebApplication1.Models
{
    public class Purchase
    {
        // ID покупки 
        public int PurchaseId { get; set; }

        // адреса покупця 
        public string Address { get; set; }
        // дата покупки 
        public DateTime Date { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        //one-to-many foreign key
        public int CustomerId { get; set; }
        // one-to-many navigation property
        public Customer Customer { get; set; }
    }
}
