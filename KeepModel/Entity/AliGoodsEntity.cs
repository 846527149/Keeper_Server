using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepModel.Entity
{
    /// <summary>
    /// 阿里妈妈促销商品汇总
    /// </summary>
    public class AliGoodsEntity
    {
        public Guid ID { get; set; }
        public string CategoryName { get; set; }
        public string NickName { get; set; }
        public string FromType { get; set; }
        public string GoodstId { get; set; }
        public string GoodsName { get; set; }
        public string ExpandLink { get; set; }
        public string GoodsImage { get; set; }
        public string Price { get; set; }
        public string Ratio { get; set; }
        public string Coupons { get; set; }
        public string Price1 { get; set; }
        public string Coupons_Count { get; set; }
        public string Coupons_Remain { get; set; }
        public string Coupons_Begin { get; set; }
        public string Coupons_End { get; set; }
        public string Coupons_Link { get; set; }
    }
}
