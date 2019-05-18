using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace StringIds.Core.Services
{
    public interface ILocalTimeService
    {
        DateTime Now { get; }
    }
}
