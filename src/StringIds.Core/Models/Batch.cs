using System;
using System.Collections.Generic;
using System.Text;

namespace StringIds.Core.Models
{
    public class Batch<T> where T : class, new()
    {
        public IEnumerable<T> Data { get; set; }
    }
}
