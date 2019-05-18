using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace StringIds.Core.Services
{
    public class LocalTimeService : ValueGenerator<DateTime>, ILocalTimeService
    {        
        public DateTime Now => DateTime.Now;

        public override bool GeneratesTemporaryValues => throw new NotImplementedException();

        public override DateTime Next(EntityEntry entry) => Now;
    }
}
