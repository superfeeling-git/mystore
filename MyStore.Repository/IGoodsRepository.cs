using MyStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyStore.Repository
{
    public interface IGoodsRepository
    {
        List<Goods> GetList();
        (int, List<Goods>) GetPage(int PageIndex = 1, int PageSize = 10);
        IQueryable<Goods> GetAll();
        (int, List<Goods>) GetPage<TKey>(IQueryable<Goods> goods, int PageIndex = 1, int PageSize = 10);
    }
}