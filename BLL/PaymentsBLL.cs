using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class PaymentsBLL
{
    private Context _context;

    public PaymentsBLL(Context context)
    {
        _context = context;
    }

    public bool Exist(int paymentId)
    {
        return _context.Payments.Any(payment => payment.PaymentId == paymentId);
    }
    public bool Insert(Payments payment)
    {
        _context.Payments.Add(payment);
        return _context.SaveChanges() > 0;
    }
    public bool Modify(Payments payment)
    {
        _context.Entry(payment).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }
    public bool Save(Payments payment)
    {
        if(!Exist(payment.PaymentId))
            return Insert(payment);
        else
            return Modify(payment);
    }
    public bool Delete(Payments payment)
    {
        _context.Entry(payment).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }
    public Payments? Search(int PaymentId)
    {
        return _context.Payments.Include(payment => payment.PaymentDetails).Where(payment => payment.PaymentId == PaymentId).SingleOrDefault();
        
    }
    public List<Payments> GetList(Expression<Func<Payments, bool>> criterion)
    {
        return _context.Payments.AsNoTracking().Where(criterion).ToList();
    }
}