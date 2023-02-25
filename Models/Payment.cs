using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payments
{
    [Key]
    public int PaymentId { get; set; }
    public DateTime Date { get; set; }
    [ForeignKey("PaymentId")]
    public virtual List<PaymentDetails> PaymentDetails { get; set; } = new List<PaymentDetails>();

}