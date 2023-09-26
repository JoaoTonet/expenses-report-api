public enum Status
{
    Submitted,
    ApprovedBySupervisor,
    RejectedBySupervisor,
    Paid,
    PaymentRejected
}

public class Expense
{
    public int Id { get; set; }
    public ExpenseReport ExpenseReport { get; set; }
    public ExpenseAccount ExpenseAccount { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateIncurred { get; set; }
    public string Explanation { get; set; }
    public Status Status { get; set; }
    public User ActionBy { get; set; }
    public DateTime ActionDate { get; set; }
    public string AccountingNotes { get; set; }
    public string Receipt { get; set; }
}