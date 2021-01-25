using Caching;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace LRUCacheTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Add_Normal_Normal()
        {
            var cache = new LRUCache<int, string>(capacity: 1000);
            var key = 1;
            var value = "Hello";
            cache.Add(key, value);

            string valueInCache;
            Assert.True(cache.TryGetValue(key, out valueInCache));
            Assert.AreEqual(value, valueInCache, "Value in cache does not match value put in");
        }

        [Test]
        public void Clear_AfterFull_CountIsZero()
        {
            var cache = new LRUCache<int, string>(capacity: 1000);

            for (int i = 0;i < 1000;i++)
            {
                cache.Add(i, i.ToString());
            }
            Assert.AreEqual(1000, cache.Count, "Cache Count should be 1000 after init");

            var key = 1;
            var value = "Hello";

            cache.Clear();

            Assert.AreEqual(0, cache.Count, "Cache Count should be 0 after clear");

            cache.Add(key, value);
            //cache.TryGetValue(key, out var valueInCache);

            //value = "Hello1";

            Assert.True(cache.TryGetValue(key, out var valueInCache));
            Assert.AreEqual(value, valueInCache, "Value1 in cache does not match value put in");
        }
    }
}
