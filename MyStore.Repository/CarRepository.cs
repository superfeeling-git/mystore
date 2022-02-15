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

<<<<<<< HEAD
        public void SetValue(string key, object value)
=======
        public void AddCar(string key, object value)
>>>>>>> a1ffbe36c9d6c1a7dd7c522efdfbd9265a734add
        {
            RedisClient.Set(key, value);
        }

<<<<<<< HEAD
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
=======

>>>>>>> a1ffbe36c9d6c1a7dd7c522efdfbd9265a734add
    }
}
