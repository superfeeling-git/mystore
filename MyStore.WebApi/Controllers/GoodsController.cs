using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStore.Service;
using MyStore.Entity;
using MyStore.Dto;

namespace MyStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private IGoodsService GoodsService;

        public GoodsController(IGoodsService GoodsService)
        {
            this.GoodsService = GoodsService;
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <returns></returns>
        /*[HttpGet]
        public IActionResult GetPage(int PageIndex = 1, int PageSize = 10)
        {
            var obj = GoodsService.GetPage(PageIndex, PageSize);

            return Ok(
                new
                {
                    count = obj.Item1,
                    list = obj.Item2
                });
        }*/

        [HttpGet]
        public IActionResult GetPage(int BrandId, int RangeId, bool isStock, string field, bool orderby, int PageIndex = 1, int PageSize = 10)
        {
            var obj = GoodsService.GetPage(BrandId, RangeId, isStock, field, orderby, PageIndex, PageSize);
            return Ok(
                new
                {
                    count = obj.Item1,
                    list = obj.Item2
                });
        }
    }
}
