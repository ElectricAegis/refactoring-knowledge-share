namespace Bloaters.Solution;

public class Customer(CustomerTransactions payments, CustomerTransactions purchases)
{
    public decimal AmountInvoicedIn(DateRange date)
    {
        return purchases.Where(x => date.InRange(x.Date))
            .Sum(x => x.Amount);
    }
    
    public decimal AmountReceivedIn(DateRange date)
    {
        return payments.Where(x => date.InRange(x.Date))
            .Sum(x => x.Amount);
    }
    
    public decimal AmountOverdueIn(DateRange date)
    {
        return AmountInvoicedIn(date) - AmountReceivedIn(date);
    }
}