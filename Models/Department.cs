public class Department
{
    public Department(int id, string name, string acronym, string description, List<User> managers)
    {
        Id = id;
        Name = name;
        Acronym = acronym;
        Description = description;
        Managers = managers;
    }

    public Department(int id, string name, string acronym, string description)
    {
        Id = id;
        Name = name;
        Acronym = acronym;
        Description = description;
        Managers = new List<User>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Acronym { get; set; }
    public string Description { get; set; }
    public List<User> Managers { get; set; }
}