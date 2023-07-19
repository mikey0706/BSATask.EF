using System.ComponentModel.DataAnnotations;

namespace BASTask.DAL.Entities;

public class Team
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<User> Users { get; set; }
    public ICollection<Project> Projects { get; set; } 
}
