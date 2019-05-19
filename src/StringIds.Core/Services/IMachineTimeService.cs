using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace StringIds.Core.Services
{
    public interface IMachineTimeService
    {
        DateTime Now { get; }
    }
}
