using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TaskManager.Models;
using TaskManager.DAL;

namespace TaskManager.DAL
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<TaskManagerContext>
    {
        protected override void Seed(TaskManagerContext context)
        {
            var random = new Random();
            var tasks = new List<Task>
    {
        new Task { Title = "Complete Project Proposal", Description = "Write a detailed proposal for the upcoming project including scope, timeline, and budget estimates.", DueDate = DateTime.Now.AddDays(random.Next(1, 30)), IsCompleted = false },
        new Task { Title = "Prepare Presentation Slides", Description = "Create PowerPoint slides for the client presentation scheduled next week. Include key project highlights and milestones.", DueDate = DateTime.Now.AddDays(random.Next(1, 30)), IsCompleted = false },
        new Task { Title = "Review Code Changes", Description = "Review and provide feedback on the recent code changes made by the development team. Ensure compliance with coding standards and best practices.", DueDate = DateTime.Now.AddDays(random.Next(1, 30)), IsCompleted = false },
        new Task { Title = "Attend Team Meeting", Description = "Attend the weekly team meeting to discuss project progress, roadblocks, and upcoming tasks. Take notes and follow up on action items.", DueDate = DateTime.Now.AddDays(random.Next(1, 30)), IsCompleted = false },
    };

            tasks.ForEach(t => context.Tasks.Add(t));
            context.SaveChanges();
        }
    }
}
