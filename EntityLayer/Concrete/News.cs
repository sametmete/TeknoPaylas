using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsHeading { get; set; }
        public string NewsContent { get; set; }
        public DateTime NewsDate { get; set; }
        public string NewsImage { get; set; }
        public bool NewsStatus { get; set; }
        public bool AdminStatus { get; set; }
    }
}
