using MyStore.Entity;
using System.Collections.Generic;

namespace MyStore.Repository
{
    public interface IBrandRepository
    {
        Brand GetEntity(int Id);
        List<Brand> GetList();
    }
}