using MyStore.Entity;
using System.Collections.Generic;

namespace MyStore.Repository
{
    public interface IGoodsRepository
    {
        List<Goods> GetList();
        (int, List<Goods>) GetPage(int PageIndex = 1, int PageSize = 10);
    }
}