namespace Bloaters.Problem;

public class Customer(string[][] payments, string[][] purchases)
{
    /// <summary>
    /// Candidate for Parameter Object
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public decimal AmountInvoicedIn(DateTime start, DateTime end)
    {
        return purchases
            .Where(x => GetDate(x[0], x[1], x[2]) >= start && GetDate(x[0], x[1], x[2]) <= end)
            .Sum(x => decimal.Parse(x[3]));
    }
    
    public decimal AmountReceivedIn(DateTime start, DateTime end)
    {
        return payments
            .Where(x => GetDate(x[0], x[1], x[2]) >= start && GetDate(x[0], x[1], x[2]) <= end)
            .Sum(x => decimal.Parse(x[3]));
    }
    
    public decimal AmountOverdueIn(decimal invoiced, decimal received)
    {
        return invoiced - received;
    }

    private static DateTime GetDate(string year, string month, string day)
    {
        return new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
    }
}