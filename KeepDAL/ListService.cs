using KeepCommon;
using KeepCommon.Log;
using KeepModel;
using KeepModel.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepDAL
{
    public class ListService
    {
        /// <summary>
        /// 最近6月趋势图
        /// </summary>
        /// <returns></returns>
        public ListResult<ChartsEntity> LineChartsList() {
            try
            {
                using (KeepDbContext context = new KeepDbContext())
                {
                    string sql = string.Format(@"select top 6 sum(price) as Price,BillName from bill 
                                                inner join Cycle 
                                                on Cycle.Id=bill.Cycle
                                                group by billname
                                                order by Price
                                                ");
                    List<ChartsEntity> result = context.Database.SqlQuery<ChartsEntity>(sql).ToList();
                    return new ListResult<ChartsEntity>(result);
                }
            }
            catch (Exception ex)
            {
                return new ListResult<ChartsEntity>(1, ex.Message);
            }
        }
        /// <summary>
        /// 获取周期分类图标数据
        /// </summary>
        /// <param name="Cycle"></param>
        /// <returns></returns>
        public ListResult<ChartsEntity> PieChartsList(Guid Cycle)
        {
            try
            {
                using (KeepDbContext context = new KeepDbContext())
                {
                    string sql = string.Format(@"select sum(price) as Price,Category from  bill
                                                where　Cycle=@Cycle
                                                group by Category");
                    var param = new List<SqlParameter>();
                    param.Add(new SqlParameter("@Cycle", Cycle));
                    List<ChartsEntity> result= context.Database.SqlQuery<ChartsEntity>(sql, param.ToArray()).ToList();
                    return new ListResult<ChartsEntity>(result);
                }
            }
            catch (Exception ex)
            {
                return new ListResult<ChartsEntity>(1, ex.Message);
            }
        }
        /// <summary>
        /// 周期列表
        /// </summary>
        /// <returns></returns>
        public ListResult<CycleEntity> CycleList()
        {
            try
            {
                KeepDbContext context = new KeepDbContext();
                var list = context.Cycle.ToList();
                return new ListResult<CycleEntity>(list);
            }
            catch (Exception ex)
            {
                ComLogger.ErrorTag("CycleList", ex.Message);
                return new ListResult<CycleEntity>(1, ex.Message);
            }
        }
    }
}
