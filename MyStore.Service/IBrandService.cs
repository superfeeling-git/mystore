using MyStore.Entity;
using System.Collections.Generic;

namespace MyStore.Service
{
    public interface IBrandService
    {
        Brand GetEntity(int id);
        List<Brand> GetList();
    }
}