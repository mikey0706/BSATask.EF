using BASTask.DAL.Entities;


namespace CollectionsAndLinq.BL.Models.Tasks
{
    public record CreateUpdateTaskDto(
    int ProjectId,
    int PerformerId,
    string Name,
    string Description,
    TaskState State,
    DateTime CreatedAt,
    DateTime? FinishedAt)
    {

    }
}
