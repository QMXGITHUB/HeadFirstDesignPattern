using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Common
{
    public static class StringListExtension
    {
        public static void ShouldContain(this List<string> list, string value)
        {
            Assert.True(list.Any(r => r.Equals(value)));
        }
    }
}