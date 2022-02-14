using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Entity;
using MyStore.Repository;

namespace MyStore.Service
{
    public class CarService : ICarService
    {
        private ICarRepository CarRepository;
        public CarService(ICarRepository CarRepository)
        {
            this.CarRepository = CarRepository;
        }

        public void AddCar(Car car)
        {
            CarRepository.AddCar($"car:{car.UserId}:{car.GoodsId}", car.BuyCount);
        }
    }
}
