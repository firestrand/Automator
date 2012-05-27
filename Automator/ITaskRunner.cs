using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automator
{
    public interface ITaskRunner
    {
        List<ITask> GetTaskList(ITaskContext taskContext);
        ITaskContext GetTaskContext();
        void ExecuteTasks();
    }
}
