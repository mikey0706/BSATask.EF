using System.ComponentModel.DataAnnotations;

namespace BASTask.DAL.Entities;

public class Project
{
    [Key]
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public User User { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime Deadline { get; set; }
    public ICollection<Task> Tasks { get; set; }
}
