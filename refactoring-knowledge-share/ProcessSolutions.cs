using Bloaters.Data;
using Bloaters.Solution;

namespace refactoring_knowledge_share;

public class ProcessSolutions
{
    public void Process()
    {
        var repo = new CustomerTransactionRepo();
        var customer = new Customer(repo.GetPayments(), repo.GetPurchases());
        var dateRange = new DateRange(new(2024, 1, 1), new(2024, 1, 31));
        var printer = new CustomerStatementPrinter();
        
        printer.Print(customer, dateRange);
    }
}

