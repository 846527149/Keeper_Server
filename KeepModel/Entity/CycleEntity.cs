using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepModel.Entity
{
    [Table("Cycle")]
    public class CycleEntity
    {
        public Guid Id { get; set; }
        public bool Make { get; set; }
        public string Bill_Begin { get; set; }
        public string Bill_End { get; set; }
        public string BillName { get; set; }
    }
}
