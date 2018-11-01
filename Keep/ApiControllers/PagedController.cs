using KeepCommon;
using KeepDAL;
using KeepModel.Entity;
using KeepModel.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Keep.ApiControllers
{
    public class PagedController : ApiController
    {
        /// <summary>
        /// 记录分页列表
        /// </summary>
        /// <param name="cycle"></param>
        /// <param name="category"></param>
        /// <param name="mode"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        [HttpGet]
        public PagedResult<BillView> BillPagedList(Guid? cycle, string category, string mode, int page, int limit)
        {
            return new PagedService().BillPagedList(cycle, category, mode, page, limit);
        }
        /// <summary>
        /// 首页记录
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        [HttpGet]
        public PagedResult<BillView> BillIndexPagedList(int page, int limit)
        {
            return new PagedService().BillIndexPagedList(page, limit);
        }
        /// <summary>
        /// 阿里促销商品
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        [HttpPost]
        public PagedResult<AliGoodsEntity> AliGoodsPagedList([FromBody]QueryParams @params)
        {
            return new PagedService().AliGoodsPagedList(@params.page, @params.limit, @params.title);
        }
        /// <summary>
        /// 查询参数
        /// </summary>
        public class QueryParams {
            /// <summary>
            /// 当前页
            /// </summary>
            public int page { get; set; }
            /// <summary>
            /// 每页显示
            /// </summary>
            public int limit { get; set; }
            /// <summary>
            /// 商品名称
            /// </summary>
            public string title { get; set; }
        }
    }
}