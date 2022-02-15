using MyStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MyStore.Repository
{
    public class GoodsRepository : IGoodsRepository
    {
        private StoreDbContext db;

        public GoodsRepository(StoreDbContext _db)
        {
            this.db = _db;
        }

        /// <summary>
        /// 获取所有商品
        /// </summary>
        /// <returns></returns>
        public List<Goods> GetList()
        {
            return db.Goods.ToList();
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public (int, List<Goods>) GetPage(int PageIndex = 1, int PageSize = 10)
        {
            var list = db.Goods.OrderBy(m => m.GoodsId);

            return (list.Count(), list.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList());
        }

        public IQueryable<Goods> GetAll()
        {
            return db.Goods.AsQueryable();
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public (int, List<Goods>) GetPage<TKey>(IQueryable<Goods> goods, int PageIndex = 1, int PageSize = 10)
        {
            return (goods.Count(), goods.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList());
        }

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Goods GetEntity(int Id)
        {
            return db.Goods.FirstOrDefault(m => m.GoodsId == Id);
        }
    }
}