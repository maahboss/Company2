using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Company.Models
{
    public class Orders
    {
        public int Id { get; set; }
        [DisplayName("رقم الطلبية")]
        public string OrderNo { get; set; }
        [DisplayName("سنة الطلبية")]
        public string Year { get; set; }
        [DisplayName("ملاحظات")]
        public string Note { get; set; }

        [DisplayName("اسم الشركة المصدرة")]
        public int ExporterId { get; set; }

        public virtual Exporter Exporter { get; set; }

        public virtual ICollection<File> File { get; set; }

    }
}