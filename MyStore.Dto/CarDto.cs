using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Dto
{
    public class CarDto
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
        public string GoodsPrice { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int BuyCount { get; set; }
    }
}
