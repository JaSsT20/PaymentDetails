using System.ComponentModel.DataAnnotations;

public class PaymentDetails
{
    [Key]
    public int PaymentDetailsId { get; set; }
    public int PaymentId { get; set; }
    public int Quantity { get; set; }

    public PaymentDetails(int PaymentId, int Quantity)
    {
        this.PaymentId = PaymentId;
        this.Quantity = Quantity;
    }
}