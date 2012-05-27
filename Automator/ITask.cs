using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automator
{
    public interface ITask
    {
        bool ShouldExecute();
        void Execute();
    }
}
