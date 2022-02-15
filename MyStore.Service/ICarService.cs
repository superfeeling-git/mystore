using MyStore.Dto;
using MyStore.Entity;
using System.Collections.Generic;

namespace MyStore.Service
{
    public interface ICarService
    {
        void AddCar(Car car);
        List<CarDto> GetCar();
        void UpdateCar(Car car);
        void DelCar(Car car);
    }
}