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
   public  class ListService
    {
        /// <summary>
        /// 周期列表
        /// </summary>
        /// <returns></returns>
        public ListResult<CycleEntity> CycleList() {
            try
            {
                KeepDbContext context = new KeepDbContext();
                var list = context.Cycle.ToList();
                return new ListResult<CycleEntity>(list);
            }
            catch (Exception ex) {
                ComLogger.ErrorTag("CycleList", ex.Message);
                return new ListResult<CycleEntity>(1, ex.Message);
            }
        }
    }
}
