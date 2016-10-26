using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatusStratery
{
    public static class StringListExtension
    {
        public static void ShouldContain(this List<string> list, string value)
        {
            Assert.IsTrue(list.Any(r => r.Equals(value)));
        }
    }
}