using CSRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Repository
{
    public class CarRepository : ICarRepository
    {
        private RedisClient RedisClient;

        public CarRepository(RedisClient RedisClient)
        {
            this.RedisClient = RedisClient;
        }

        public void SetValue(string key, object value)
        {
            RedisClient.Set(key, value);
        }

        public string[] GetKeys(string pattern)
        {
            return RedisClient.Keys(pattern);
        }

        public string GetValue(string key)
        {
            return RedisClient.Get(key);
        }

        public long Del(string key)
        {
            return RedisClient.Del(key);
        }
    }
}
