using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automator
{
    public class TaskRunner : ITaskRunner
    {
        public List<ITask> GetTaskList(ITaskContext taskContext)
        {
            throw new NotImplementedException();
        }

        public ITaskContext GetTaskContext()
        {
            throw new NotImplementedException();
        }

        public void ExecuteTasks()
        {
            throw new NotImplementedException();
        }
    }
}
