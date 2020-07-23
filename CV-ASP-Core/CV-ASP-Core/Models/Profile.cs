using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Models {
    public class Profile {

        public int Age { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string BirthDate { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Job { get; set; }
        public string Location { get; set; }
        public IEnumerable<Hobby> Hobbies { get; set; }
    }
}
