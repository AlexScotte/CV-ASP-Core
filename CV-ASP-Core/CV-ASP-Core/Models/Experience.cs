using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Models {
    public class Experience {

        public ExperienceDetails Details { get; set; }
        public int Id { get; set; }
        public string Duration { get; set; }
        public string Job { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
