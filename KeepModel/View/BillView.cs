using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepModel.View
{
    public class BillView
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime RecordDate { get; set; }
        public decimal Price { get; set; }
        public string Detailed { get; set; }
        public string Category { get; set; }
        public string Creator { get; set; }
        public string Mode { get; set; }
        public string Bill_Begin { get; set; }
        public string Bill_End { get; set; }
        public string BillName { get; set; }
        public Guid Cycle { get; set; }
    }
}
