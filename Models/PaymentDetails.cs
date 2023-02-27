using System.ComponentModel.DataAnnotations;

public class PaymentDetails
{
    [Key]
    public int Id { get; set; }
    public int PaymentId { get; set; }
    public int LendId { get; set; }
    public float PaidValue { get; set; }
}