using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Repository;
using MyStore.Entity;
using MyStore.Dto;

namespace MyStore.Service
{
    public class BrandService : IBrandService
    {
        private IBrandRepository BrandRepository;

        public BrandService(IBrandRepository BrandRepository)
        {
            this.BrandRepository = BrandRepository;
        }

        public Brand GetEntity(int id)
        {
            return BrandRepository.GetEntity(id);
        }

        public List<Brand> GetList()
        {
            return BrandRepository.GetList();
        }
    }
}
