using System;
using toom1s.TaskPlanner.Domain.Models.Enums;

namespace toom1s.TaskPlanner.Domain.Models
{
    public class WorkItem
    {
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Complexity Complexity { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public Guid Id { get; set; }

        public WorkItem Clone()
        {
            return new WorkItem
            {
                CreationDate = this.CreationDate,
                DueDate = this.DueDate,
                Priority = this.Priority,
                Complexity = this.Complexity,
                Title = this.Title,
                Description = this.Description,
                IsCompleted = this.IsCompleted,
                Id = this.Id // If Id should be unique for each clone, you may assign `Guid.NewGuid()` instead
            };
        }

        public override string ToString()
        {
            string formattedDueDate = DueDate.ToString("dd.MM.yyyy");
            string priorityString = Priority.ToString().ToLower();
            return $"{Title}: due {formattedDueDate}, {priorityString} priority";
        }
    }
}
