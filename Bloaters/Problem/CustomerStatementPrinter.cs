namespace Bloaters.Problem;

public class CustomerStatementPrinter
{
    /// <summary>
    /// Candidate for Preserve Whole Object
    /// </summary>
    /// <param name="invoiced"></param>
    /// <param name="received"></param>
    /// <param name="overdue"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    public void Print(decimal invoiced, decimal received, decimal overdue, DateTime startDate, DateTime endDate)
    {
        Console.WriteLine($"Amount Invoiced in {startDate} to {endDate}: {invoiced}");
        Console.WriteLine($"Amount Received in {startDate} to {endDate}: {received}");
        Console.WriteLine($"Amount Overdue in {startDate} to {endDate}: {overdue}");
    }
}