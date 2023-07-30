using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Client.Models;

namespace GameStore.Client;

public static class TaskClient
{
    private static readonly List<TaskModel> tasks = new()
{
    new TaskModel()
    {
        ID = 1,
        Name = "Build Task Manager",
        Priority = "High",
        Status = "Pending",
        Deadline = new DateTime(2023 , 7 , 31)

    },
    new TaskModel()
    {
        ID = 2,
        Name = "Update Navbar",
        Priority = "Meduim",
        Status = "Done",
        Deadline = new DateTime(2023 , 2 , 8)

    }

};

    public static TaskModel[] GetTasks()
    {
        return tasks.ToArray();
    }

    public static void AddTask(TaskModel task)
    {
        task.ID = tasks.Max(task => task.ID) + 1;
        tasks.Add(task);
    }
}