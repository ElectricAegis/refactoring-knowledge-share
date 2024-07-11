namespace Bloaters.Solution;

public class CustomerTransaction(string[] transaction)
{
    public DateTime Date => new(int.Parse(transaction[0]), int.Parse(transaction[1]), int.Parse(transaction[2]));

    public decimal Amount => decimal.Parse(transaction[3]);
    
    public static implicit operator CustomerTransaction(string[] transaction) => new(transaction);
}