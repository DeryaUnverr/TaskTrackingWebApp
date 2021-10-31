using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.Business.Interfaces
{
    public interface ICustomLogger
    {
        public void LogError(string message);
    }
}
