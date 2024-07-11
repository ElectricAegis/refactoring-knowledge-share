namespace Bloaters.Solution;

public class CustomerStatementPrinter
{
    public void Print(Customer customer, DateRange dateRange)
    {
        Console.WriteLine($"Amount Invoiced in {dateRange.Start} to {dateRange.End}: {customer.AmountInvoicedIn(dateRange)}");
        Console.WriteLine($"Amount Received in {dateRange.Start} to {dateRange.End}: {customer.AmountReceivedIn(dateRange)}");
        Console.WriteLine($"Amount Overdue in {dateRange.Start} to {dateRange.End}: {customer.AmountOverdueIn(dateRange)}");
    }
}