public enum AccountType
{
    Asset,
    Expense
}

public class ExpenseAccount
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public AccountType Type { get; set; }
}