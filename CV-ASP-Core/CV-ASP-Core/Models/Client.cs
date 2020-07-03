using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Models {
    public class Client {

        public Experience Experience { get; set; }
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
    }
}
