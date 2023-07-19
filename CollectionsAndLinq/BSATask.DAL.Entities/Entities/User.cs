using System.ComponentModel.DataAnnotations;

namespace BASTask.DAL.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    public int? TeamId { get; set; }
    public Team Team { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime RegisteredAt { get; set; }
    public DateTime BirthDay { get; set; }
    public ICollection<Task> Tasks { get; set; }
    public ICollection<Project> Projects { get; set; } 
}
