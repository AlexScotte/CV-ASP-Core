using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CV_ASP_Core.Models {
    public class MyCV {

        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<Formation> Formations { get; set; }

        public override string ToString() => JsonSerializer.Serialize<MyCV>(this);
    }
}
