using CV_ASP_Core.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CV_ASP_Core.Services {
    public class JsonFileFormationService : ServiceBase {
        public JsonFileFormationService(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment) {

        }

        public IEnumerable<Formation> GetFormations() {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var json = jsonFileReader.ReadToEnd();
                JObject jObject = JObject.Parse(json);
                IList<Formation> formations = new List<Formation>();
                IList<JToken> jTokens = jObject["formations"].Children().ToList();

                foreach (JToken jToken in jTokens)
                {
                    Formation formation = jToken.ToObject<Formation>();
                    formations.Add(formation);
                }

                return formations;
            }
        }
    }
}
