using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace MCaches {
    /// <summary>
    /// 
    /// </summary>
    public class SubMain {
        public SubMain() {
            LoadDB();
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadDB() {
            ObjectCache cache = MemoryCache.Default;
            if (cache.Contains("CachedValue")) {
                var value = cache.Get("CachedValue");
            } 
            else {
                cache.Add("CachedValue", "SomeValue to cache", new CacheItemPolicy());
            }
        }
    }
}
