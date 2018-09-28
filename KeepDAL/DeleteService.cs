using KeepCommon;
using KeepCommon.Log;
using KeepModel;
using KeepModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepDAL
{
    /// <summary>
    /// 删除 Service
    /// </summary>
    public class DeleteService
    {
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        public ServiceResult DeleteBill(BillEntity @params)
        {
            try
            {
                using (KeepDbContext context = new KeepDbContext())
                {
                    BillEntity entity = context.Bill.SingleOrDefault(x => x.Id == @params.Id);
                    if (entity == null) {
                        return new ServiceResult(1, "entity is null");
                    }
                    context.Bill.Remove(entity);
                    context.SaveChanges();
                    return new ServiceResult();
                }
            }
            catch (Exception ex)
            {
                ComLogger.ErrorTag("DeleteBill", ex.InnerException.StackTrace);
                return new ServiceResult(1, ex.Message);
            }
        }
    }
}
