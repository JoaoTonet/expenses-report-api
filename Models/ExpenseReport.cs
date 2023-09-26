public class ExpenseReport
{
    public int Id { get; set; }
    public User User { get; set; }
    public Department Department { get; set; }
    public Project Project { get; set; }
    public Status Status { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal AmountApproved { get; set; }
    public decimal AmountRejected { get; set; }
    public decimal AmountPaid { get; set; }
    public User PaidBy { get; set; }
    public DateTime PaidDate { get; set; }
    public string StatusNotes { get; set; }
    public string ProofOfPayment { get; set; }
    public List<Expense> Expenses { get; set; }
}