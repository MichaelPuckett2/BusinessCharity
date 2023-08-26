using System.Collections.ObjectModel;

namespace Charity;

public class Manager
{
    public string Name { get; set; } = "My Business";
    public ObservableCollection<Transaction> Credits { get; } = new ObservableCollection<Transaction>();
    public ObservableCollection<Transaction> Debits { get; } = new ObservableCollection<Transaction>();
}


public class Transaction
{
    public double Value { get; set; }
    public TransactionType TransactionType { get; set; }
}

public enum TransactionType
{
    None,
    Credit,
    Debit
}
