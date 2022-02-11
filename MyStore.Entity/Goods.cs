using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Entity
{
    public class Goods
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public int GoodsId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 缩略图（列表图片）
        /// </summary>
        public string GoodsThum { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal GoodsPrice { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public Brand Brand { get; set; }
        public string Details { get; set; }
    }
}
