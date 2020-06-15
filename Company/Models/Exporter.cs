using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Company.Models
{
    public class Exporter
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="اسم الشركة")]
        public string Name { get; set; }
        public string Note { get; set; }


        public virtual ICollection<Orders> Order { get; set; }
        public virtual ICollection<File> Files { get; set; }


    }
}