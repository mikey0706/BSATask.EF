﻿using System.ComponentModel.DataAnnotations;

namespace BASTask.DAL.Entities;

public class Task
{
    [Key]
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
    public int PerformerId { get; set; }
    public User User { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public TaskState State { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? FinishedAt { get; set; }

}
