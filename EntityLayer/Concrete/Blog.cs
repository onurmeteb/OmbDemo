using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        //string yaptı
        public DateTime BlogCreateDate { get; set; }
        public bool DataStatus { get; set; }

        //???
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
