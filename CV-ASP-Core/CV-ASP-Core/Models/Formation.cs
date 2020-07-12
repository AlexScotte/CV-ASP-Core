using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Models {
    public class Formation {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Establishment { get; set; }
        public string Url { get; set; }

       // public override string ToString() => System.Text.Json.JsonSerializer.Serialize<Formation>(this);
    }
}
