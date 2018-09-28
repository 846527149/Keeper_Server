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
    public class CreateController : ApiController
    {
        /// <summary>
        /// 新增记录
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpPost]
        public ServiceResult CreateBill(BillEntity @params)
        {
            return new CreateService().CreateBill(@params);
        }
    }
}