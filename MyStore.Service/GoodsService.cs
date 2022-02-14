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
    public class GoodsService : IGoodsService
    {
        private IGoodsRepository GoodsRepository;
        public GoodsService(IGoodsRepository GoodsRepository)
        {
            this.GoodsRepository = GoodsRepository;
        }

        public (int, List<Goods>) GetPage(int PageIndex = 1, int PageSize = 10)
        {
            return GoodsRepository.GetPage(PageIndex, PageSize);
        }
    }
}
