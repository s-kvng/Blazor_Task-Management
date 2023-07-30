namespace GameStore.Client.Models;

public class TaskModel
{
    public int ID { get; set; }
    public required string Name { get; set; }
    public required string Priority { get; set; }
    public required string Status { get; set; }
    public DateTime Deadline { get; set; }
}