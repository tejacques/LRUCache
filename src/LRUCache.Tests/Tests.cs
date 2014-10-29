using Caching;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCacheTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestCreate()
        {
            var cache = new LRUCache<int, string>(capacity: 1000);
            var key = 1;
            var value = "Hello";
            cache.Add(key, value);

            string valueInCache;
            Assert.True(cache.TryGetValue(key, out valueInCache));
            Assert.AreEqual(value, valueInCache, "Value in cache does not match value put in");
        }
    }
}
