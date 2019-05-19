using System;

namespace StringIds.Core.Services
{
    public class MachineTimeService : IMachineTimeService
    {        
        public DateTime Now => DateTime.Now;
    }
}
