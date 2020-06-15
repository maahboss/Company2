using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Company.Models
{
    public class File
    {
        public int Id { get; set; }
        [DisplayName("الصورة او الملف")]
        public string Image { get; set; }
        [DisplayName("نوع الصورة او الملف")]
        public string ImageType { get; set; }
        [DisplayName("ملاحظة")]
        public string Note { get; set; }
        [DisplayName("رقم الطلبية")]
        public int OrderId { get; set; }
        [DisplayName("اسم الشركة")]
        public int ExporterName { get; set; }


        public virtual Orders Order { get; set; }
        public virtual Exporter exporters { get; set; }



    }
}