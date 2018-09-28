using KeepModel.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepModel
{
    public class KeepDbContext: DbContext
    {
        public KeepDbContext()
          : base("name=KeepDbContext")//与Config中数据库连接字符串名称一样
        {
        }
        public virtual DbSet<CycleEntity> Cycle { get; set; }
        public virtual DbSet<BillEntity> Bill { get; set; }

    }
}
