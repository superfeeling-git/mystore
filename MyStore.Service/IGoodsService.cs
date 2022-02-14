using MyStore.Entity;
using System.Collections.Generic;

namespace MyStore.Service
{
    public interface IGoodsService
    {
        (int, List<Goods>) GetPage(int PageIndex = 1, int PageSize = 10);
        (int, List<Goods>) GetPage(int BrandId, int RangId, bool isStock, string field, bool orderby, int PageIndex = 1, int PageSize = 10);
    }
}