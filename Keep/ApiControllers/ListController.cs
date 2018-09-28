using KeepCommon;
using KeepDAL;
using KeepModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Keep.ApiControllers
{
    public class ListController : ApiController
    {
        /// <summary>
        /// 周期列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ListResult<CycleEntity> CycleList() {
            return new ListService().CycleList();
        }
    }
}