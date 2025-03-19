using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Shop_Order
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Site_User")]
        public int User_Id { get; set; }
        public DateTime Order_Date { get; } = DateTime.Now;
        [ForeignKey("User_Payment_Method")]
        public int Payment_Method_Id { get; set; }
        [ForeignKey("Address")]
        public int Shipping_Address_Id {  get; set; }

        [ForeignKey("Shipping_Method")]
        public int Shipping_Method_Id { get; set; }
        public decimal Order_Total { get; set; }
        [ForeignKey("Order_Status")]
        public int Order_Status_Id { get; set; }

        public virtual Order_Status? Order_Status { get; set; }
        public virtual Shipping_Method? Shipping_Method { get; set; }
        public virtual Address? Address { get; set; }
        public virtual User_Payment_Method? User_Payment_Method { get; set; }
        public virtual Site_User? Site_User { get; set; }
        public virtual List<Order_Line>? Order_Lines { get; set; }
        
    }
}
