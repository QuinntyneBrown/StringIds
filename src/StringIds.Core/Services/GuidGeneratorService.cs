using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace StringIds.Core.Services
{
    public class GuidGeneratorService : ValueGenerator<string>, IGuidGeneratorService
    {
        public override bool GeneratesTemporaryValues => throw new System.NotImplementedException();

        public override string Next(EntityEntry entry) => $"{Guid.NewGuid()}";
    }
}
