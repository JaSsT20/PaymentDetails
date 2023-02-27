using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payments
{
    [Key]
    public int PaymentId { get; set; }
    public DateTime Date { get; set; }
    public int PersonId { get; set; }
    public string? Concept { get; set; }
    public float Amount { get; set; }
    
    [ForeignKey("PaymentId")]
    public PaymentDetails PaymentDetails { get; set; } = new PaymentDetails();
//    public List<PaymentDetails> PaymentDetails { get; set; } = new List<PaymentDetails>();

}