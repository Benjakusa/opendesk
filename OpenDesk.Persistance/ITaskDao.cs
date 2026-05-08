using System;
using System.Collections.Generic;
using OpenDesk.Domain.Models.Tasks;

namespace OpenDesk.Persistance
{
    public interface ITaskDao
    {
        void SaveTask(Task task);
        IEnumerable<Task> GetTasks(int taskTypeId, DateTime endDate);
    }
}
