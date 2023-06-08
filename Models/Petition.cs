namespace PetitionAdminApp.Models;

public class Petition
{
    public Petition() 
    {
    }
    
    public Petition(int id, string name, string description, DateTime time)
    {
        Id = id;
        Name = name;
        Description = description;
        EntryDate = time;
    }

    public Petition(Petition petition)
    {
        Id = petition.Id;
        Name = petition.Name;
        Description = petition.Description;
        EntryDate = petition.EntryDate;
    }
    
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime EntryDate { get; set; }
}