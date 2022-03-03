using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace floesm_pro.Model
{
    [Table("uploadImages")]
    public class UploadedImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
    }
}
