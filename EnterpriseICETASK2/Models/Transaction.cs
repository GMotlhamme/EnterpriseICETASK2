using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseICETASK2.Models
{
    public class Transaction 
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal	Subtotal { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal VAT {  get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal FinalTotal { get; set; }
        public DateTime Date {  get; set; }

    }
}
