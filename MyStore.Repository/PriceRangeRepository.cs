using MyStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Repository
{
    public class PriceRangeRepository : IPriceRangeRepository
    {
        private StoreDbContext db;

        public PriceRangeRepository(StoreDbContext _db)
        {
            this.db = _db;
        }

        /// <summary>
        /// 获取所有价格区间
        /// </summary>
        /// <returns></returns>
        public List<PriceRange> GetList()
        {
            return db.PriceRanges.ToList();
        }

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public PriceRange GetEntity(int Id)
        {
            return db.PriceRanges.FirstOrDefault(m => m.PriceRangeId == Id);
        }
    }
}
