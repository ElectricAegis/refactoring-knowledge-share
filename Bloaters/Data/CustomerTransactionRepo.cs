namespace Bloaters.Data;

public class CustomerTransactionRepo
{
    public string[][] GetPayments()
    {
        return
        [
            ["2024", "1", "2", "100.2"],
            ["2024", "1", "3", "100"],
            ["2024", "1", "8", "100.5"],
            ["2024", "2", "14", "100"]
        ];
    }
    
    public string[][] GetPurchases()
    {
        return
        [
            ["2024", "1", "2", "100"],
            ["2024", "1", "3", "99.8"],
            ["2024", "1", "8", "100"],
            ["2024", "1", "30", "50.32"]
        ];
    }
}