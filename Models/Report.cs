namespace expenses_report_api;

public class Report
{
    public Report () {}
    public Report(int id, double value, string department)
    {
        Id = id;
        Value = value;
        Department = department;
    }
    public int Id { get; set; }
    public double? Value { get; set; }
    public string? Department { get; set; }
}
