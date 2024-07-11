using Bloaters.Data;
using Bloaters.Problem;

namespace refactoring_knowledge_share;

public class ProcessProblems
{
    public void Process()
    {
        var repo = new CustomerTransactionRepo();

        var customer = new Customer(repo.GetPayments(), repo.GetPurchases());

        var startDate = new DateTime(2024, 1, 1);
        var endDate = new DateTime(2024, 1, 31);

        var amountInvoicedIn = customer.AmountInvoicedIn(startDate, endDate);
        var amountReceivedIn = customer.AmountReceivedIn(startDate, endDate);
        // candidate for Replace Parameter with Method Call
        var amountOverdueIn = customer.AmountOverdueIn(amountInvoicedIn, amountReceivedIn);
        var printer = new CustomerStatementPrinter();
        printer.Print(amountInvoicedIn, amountReceivedIn, amountOverdueIn, startDate, endDate);
    }
}