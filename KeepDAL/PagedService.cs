using KeepCommon;
using KeepModel;
using KeepModel.Entity;
using KeepModel.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepDAL
{
    public class PagedService
    {
        /// <summary>
        /// 阿里促销商品
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public PagedResult<AliGoodsEntity> AliGoodsPagedList(int page, int limit,string title) {
            try
            {
                using (KeepDbContext context = new KeepDbContext())
                {
                    var total = new SqlParameter("@total", SqlDbType.Int);
                    total.Direction = ParameterDirection.Output;
                    var pageParam = new SqlParameter("@page", SqlDbType.Int);
                    pageParam.Value = page;
                    var limitParam = new SqlParameter("@limit", SqlDbType.Int);
                    limitParam.Value = limit;
                    var titleParam = new SqlParameter("@title", SqlDbType.VarChar);
                    titleParam.Value = title;
                    var parm = new SqlParameter[] { pageParam, limitParam, titleParam, total };
                    string sql = @"EXEC [dbo].[SP_QueryAliGoodsList] @page,@limit,@title,@total OUTPUT";
                    List<AliGoodsEntity> list = context.Database.SqlQuery<AliGoodsEntity>(sql, parm).ToList();
                    return new PagedResult<AliGoodsEntity>(page, limit, (int)total.Value, list);
                }
            }
            catch (Exception ex)
            {
                return new PagedResult<AliGoodsEntity>(1, ex.Message);
            }
        }
        /// <summary>
        /// 首页记录
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>

        public PagedResult<BillView> BillIndexPagedList(int page, int limit)
        {
            try
            {
                using (KeepDbContext context = new KeepDbContext())
                {
                    var total = new SqlParameter("@total", SqlDbType.Int);
                    total.Direction = ParameterDirection.Output;
                    var pageParam = new SqlParameter("@page", SqlDbType.Int);
                    pageParam.Value = page;
                    var limitParam = new SqlParameter("@limit", SqlDbType.Int);
                    limitParam.Value = limit;
                    var parm = new SqlParameter[] { pageParam, limitParam, total };
                    string sql = @"EXEC [dbo].[SP_QueryBillIndex] @page,@limit,@total OUTPUT";
                    List<BillView> list = context.Database.SqlQuery<BillView>(sql, parm).ToList();
                    return new PagedResult<BillView>(page, limit, (int)total.Value, list);
                }
            }
            catch (Exception ex)
            {
                return new PagedResult<BillView>(1, ex.Message);
            }
        }
        /// <summary>
        /// 记录分页列表
        /// </summary>
        /// <param name="cycle"></param>
        /// <param name="category"></param>
        /// <param name="mode"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public PagedResult<BillView> BillPagedList(Guid? cycle, string category, string mode, int page, int limit)
        {
            try
            {
                using (KeepDbContext context = new KeepDbContext())
                {
                    var total = new SqlParameter("@total", SqlDbType.Int);
                    total.Direction = ParameterDirection.Output;
                    var cycleParam = new SqlParameter("@cycle", SqlDbType.UniqueIdentifier);
                    cycleParam.Value = cycle;
                    if (cycle == null)
                        cycleParam.Value = DBNull.Value;
                    var categoryParam = new SqlParameter("@category", SqlDbType.NVarChar);
                    categoryParam.Value = category;
                    if (category == null)
                        categoryParam.Value = DBNull.Value;
                    var modeParam = new SqlParameter("@mode", SqlDbType.NVarChar);
                    modeParam.Value = mode;
                    if (mode == null)
                        modeParam.Value = DBNull.Value;
                    var pageParam = new SqlParameter("@page", SqlDbType.Int);
                    pageParam.Value = page;
                    var limitParam = new SqlParameter("@limit", SqlDbType.Int);
                    limitParam.Value = limit;
                    var parm = new SqlParameter[] { cycleParam, categoryParam, modeParam, pageParam, limitParam, total };
                    string sql = @"EXEC [dbo].[SP_QueryBill] @cycle,@category,@mode,@page,@limit,@total OUTPUT";
                    List<BillView> list = context.Database.SqlQuery<BillView>(sql, parm).ToList();
                    return new PagedResult<BillView>(page, limit, (int)total.Value, list);

                }
            }
            catch (Exception ex)
            {
                return new PagedResult<BillView>(1, ex.Message);
            }
        }
    }
}
