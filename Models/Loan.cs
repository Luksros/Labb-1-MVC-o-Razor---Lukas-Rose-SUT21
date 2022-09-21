namespace Labb_1_MVC_o_Razor_v2.Models
{
    public class Loan
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
        public int BookID { get; set; }
        public Book? Book { get; set; }
        public DateTime LoanStart { get; set; }
        public DateTime LoanEnd { get; set; }
        public bool Returned { get; set; }
    }
}
