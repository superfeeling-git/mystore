using MyStore.Entity;
using System.Collections.Generic;

namespace MyStore.Repository
{
    public interface IPriceRangeRepository
    {
        PriceRange GetEntity(int Id);
        List<PriceRange> GetList();
    }
}