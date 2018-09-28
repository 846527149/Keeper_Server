using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepModel.Entity
{
    [Table("Bill")]
    public class BillEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime RecordDate { get; set; }
        public decimal Price { get; set; }
        public string Detailed { get; set; }
        public string Category { get; set; }
        public string Creator { get; set; }
        public string Mode { get; set; }
        public Guid Cycle { get; set; }

    }
}
