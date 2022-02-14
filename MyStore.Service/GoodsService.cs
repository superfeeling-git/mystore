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
        private IPriceRangeRepository PriceRangeRepository;

        public GoodsService(IGoodsRepository GoodsRepository, IPriceRangeRepository PriceRangeRepository)
        {
            this.GoodsRepository = GoodsRepository;
            this.PriceRangeRepository = PriceRangeRepository;
        }

        public (int, List<Goods>) GetPage(int PageIndex = 1, int PageSize = 10)
        {
            return GoodsRepository.GetPage(PageIndex, PageSize);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BrandId">品牌</param>
        /// <param name="Rangid">价格区间</param>
        /// <param name="isStock">是否查看有库存</param>
        /// <param name="field">排序字段</param>
        /// <param name="orderby">正序倒序</param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public (int, List<Goods>) GetPage(int BrandId,int RangeId,bool isStock,string field,bool orderby, int PageIndex = 1, int PageSize = 10)
        {
            var list = GoodsRepository.GetAll();
            //品牌
            if(BrandId > 0)
            {
                list = list.Where(m => m.BrandId == BrandId);
            }
            //价格区间
            if(RangeId > 0)
            {
                var range = PriceRangeRepository.GetEntity(RangeId);
                list = list.Where(m => m.GoodsPrice >= range.Min && m.GoodsPrice <= range.Max);
            }
            //库存
            if (isStock)
            {
                list = list.Where(m => m.Stock > 0);
            }
            
            //默认的排序
            list = list.OrderBy(m => m.GoodsId);

            //排序字段：库存、价格
            if (field == "stock")
            {
                list = orderby ? list.OrderBy(m => m.Stock) : list.OrderByDescending(m => m.Stock);
            }
            //排序字段：库存、价格
            if (field == "price")
            {
                list = orderby ? list.OrderBy(m => m.GoodsPrice) : list.OrderByDescending(m => m.GoodsPrice);
            }
            return GoodsRepository.GetPage<int>(list, PageIndex, PageSize);
        }
    }
}
