using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using MyStore.Dto;
=======
>>>>>>> a1ffbe36c9d6c1a7dd7c522efdfbd9265a734add
using MyStore.Entity;
using MyStore.Repository;

namespace MyStore.Service
{
    public class CarService : ICarService
    {
        private ICarRepository CarRepository;
<<<<<<< HEAD
        private IUserService UserService;
        private IGoodsRepository GoodsRepository;

        public CarService(ICarRepository CarRepository, IUserService UserService, IGoodsRepository GoodsRepository)
        {
            this.CarRepository = CarRepository;
            this.UserService = UserService;
            this.GoodsRepository = GoodsRepository;
=======
        public CarService(ICarRepository CarRepository)
        {
            this.CarRepository = CarRepository;
>>>>>>> a1ffbe36c9d6c1a7dd7c522efdfbd9265a734add
        }

        public void AddCar(Car car)
        {
<<<<<<< HEAD
            //逻辑判断
            //如果有重复的商品，需要逻辑处理
            var list = GetCar();

            //更新
            //添加
            CarRepository.SetValue($"car:{UserService.LoginInfo().UserId}:{car.GoodsId}", car.BuyCount);
        }

        public void UpdateCar(Car car)
        {
            CarRepository.SetValue($"car:{UserService.LoginInfo().UserId}:{car.GoodsId}", car.BuyCount);
        }

        public void DelCar(Car car)
        {
            CarRepository.Del($"car:{UserService.LoginInfo().UserId}:{car.GoodsId}");
        }

        //获取购物车数据
        public List<CarDto> GetCar()
        {
            var keys = CarRepository.GetKeys($"car:{UserService.LoginInfo().UserId}:*");

            //购买数量
            //var counts = keys.Select(m => CarRepository.GetValue(m));

            List<CarDto> cars = new List<CarDto>();

            foreach (var key in keys)
            {
                //商品ID
                var goodsId = int.Parse(key.Split(":").Last());
                var goods = GoodsRepository.GetEntity(goodsId);

                CarDto car = new CarDto {
                    GoodsId = goodsId,
                    GoodsName = goods.GoodsName,
                    GoodsPrice = goods.GoodsPrice.ToString("#0.00"),
                    GoodsThum = goods.GoodsThum,
                    BuyCount = int.Parse(CarRepository.GetValue($"car:{UserService.LoginInfo().UserId}:{goodsId}"))
                };

                cars.Add(car);
            }

            return cars;
=======
            CarRepository.AddCar($"car:{car.UserId}:{car.GoodsId}", car.BuyCount);
>>>>>>> a1ffbe36c9d6c1a7dd7c522efdfbd9265a734add
        }
    }
}
