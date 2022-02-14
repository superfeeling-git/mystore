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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PriceRangeController : ControllerBase
    {
        private IPriceRangeService PriceRangeService;
        public PriceRangeController(IPriceRangeService PriceRangeService)
        {
            this.PriceRangeService = PriceRangeService;
        }

        /// <summary>
        /// 获取列表数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetList()
        {
            return new JsonResult(PriceRangeService.GetList());
        }

        /// <summary>
        /// 获取单条实体
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetEntity(int id)
        {
            return Ok(PriceRangeService.GetEntity(id));
        }
    }
}
