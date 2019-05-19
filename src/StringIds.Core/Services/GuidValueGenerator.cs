using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace StringIds.Core.Services
{
    public class GuidValueGenerator : ValueGenerator<string>
    {
        public override bool GeneratesTemporaryValues => throw new System.NotImplementedException();

        public override string Next(EntityEntry entry = null) => $"{Guid.NewGuid()}";
    }
}
