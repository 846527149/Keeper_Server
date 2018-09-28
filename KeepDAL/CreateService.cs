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
   public class CreateService
    {
        /// <summary>
        /// 新增记录
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        public ServiceResult CreateBill(BillEntity @params) {
            try
            {
                using (KeepDbContext context = new KeepDbContext()) {
                    @params.Id = Guid.NewGuid();
                    @params.CreateDate = DateTime.Now;
                    context.Bill.Add(@params);
                    context.SaveChanges();
                    return new ServiceResult();
                }
            }
            catch (Exception ex) 
            {
                ComLogger.ErrorTag("CreateBill", ex.InnerException.StackTrace);
                return new ServiceResult(1, ex.Message);
            }
        }
    }
}
