using MyStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Repository
{
    public class BrandRepository : IBrandRepository
    {
        private StoreDbContext db;

        public BrandRepository(StoreDbContext _db)
        {
            this.db = _db;
        }

        /// <summary>
        /// 获取所有品牌
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetList()
        {
            return db.Brands.ToList();
        }

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Brand GetEntity(int Id)
        {
            return db.Brands.FirstOrDefault(m => m.BrandId == Id);
        }
    }
}
