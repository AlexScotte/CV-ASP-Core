using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Models {
    public class Contact {

        public string CvUrl { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IEnumerable<ExternalLink> ExternalLinks { get; set; }
    }
}
