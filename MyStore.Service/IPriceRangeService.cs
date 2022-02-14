using MyStore.Dto;
using MyStore.Entity;
using System.Collections.Generic;

namespace MyStore.Service
{
    public interface IPriceRangeService
    {
        PriceRange GetEntity(int id);
        List<PriceRangeDto> GetList();
    }
}