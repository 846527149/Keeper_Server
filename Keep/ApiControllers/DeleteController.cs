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
    public class DeleteController : ApiController
    {
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpPost]
        public ServiceResult DeleteBill(BillEntity @params) {
            return new DeleteService().DeleteBill(@params);
        }
    }
}