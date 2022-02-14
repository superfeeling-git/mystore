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

        public void AddCar(string key, object value)
        {
            RedisClient.Set(key, value);
        }


    }
}
