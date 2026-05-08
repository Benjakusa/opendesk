using System.Collections.Generic;
using OpenDesk.Domain.Models.Tasks;

namespace OpenDesk.Presentation.Services.Implementations.TaskModule
{
    class TaskCache
    {
        public IEnumerable<Task> Tasks { get; set; }
        public TaskCache()
        {
            Tasks = new List<Task>();
        }
    }
}