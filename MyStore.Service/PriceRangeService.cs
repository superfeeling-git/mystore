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
    public class PriceRangeService : IPriceRangeService
    {
        private IPriceRangeRepository PriceRangeRepository;
        public PriceRangeService(IPriceRangeRepository PriceRangeRepository)
        {
            this.PriceRangeRepository = PriceRangeRepository;
        }

        public PriceRange GetEntity(int id)
        {
            return PriceRangeRepository.GetEntity(id);
        }

        public List<PriceRangeDto> GetList()
        {
            return PriceRangeRepository.GetList().Select(m => new PriceRangeDto 
            {
             PriceRangeId = m.PriceRangeId,
             PriceRangeName = $"{m.Min}-{m.Max}"
            }).ToList();
        }
    }
}
