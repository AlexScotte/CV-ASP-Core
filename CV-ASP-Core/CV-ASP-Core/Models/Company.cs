using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CV_ASP_Core.Models {
    public class Company {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string Job { get; set; }
        public string Department { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }

        public IEnumerable<Client> Clients { get; set; }

        public override string ToString() => System.Text.Json.JsonSerializer.Serialize<Company>(this);

        [JsonIgnore]
        public bool IsExpanded { get; set; } = true;
    }
}
