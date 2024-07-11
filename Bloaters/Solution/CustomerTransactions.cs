using System.Collections;

namespace Bloaters.Solution;

public class CustomerTransactions : IEnumerable<CustomerTransaction>
{
    private readonly List<CustomerTransaction> _customerTransactions = [];
    
    public CustomerTransactions(IEnumerable<string[]> transactions)
    {
        foreach (var transaction in transactions)
        {
            _customerTransactions.Add(transaction);
        }
    }

    public IEnumerator<CustomerTransaction> GetEnumerator()
    {
        return _customerTransactions.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public static implicit operator CustomerTransactions(string[][] transactions) => new(transactions);
}