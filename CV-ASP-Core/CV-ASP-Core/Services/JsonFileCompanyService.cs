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
    public class JsonFileCompanyService : ServiceBase {
        public JsonFileCompanyService(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment) {
        }

        public IEnumerable<Company> GetCompanies() {
            using (var jsonFileReader = File.OpenText(JsonFileName)) {

                var json = jsonFileReader.ReadToEnd();
                JObject jObject = JObject.Parse(json);
                IList<Company> companies = new List<Company>();
                IList<JToken> jTokens = jObject["companies"].Children().ToList();

                foreach (JToken jToken in jTokens)
                {
                    Company company = jToken.ToObject<Company>();
                    companies.Add(company);
                }

                return companies;
            }
        }

        public IEnumerable<Skill> GetDistinctSkills()
        {
            IEnumerable<Skill> skills = this.GetCompanies()?.SelectMany(co => co.Clients)?.SelectMany(cl => cl.Experience?.Skills)?.Where(sk => sk.Important == 1)?.GroupBy(sk => sk.Name)?.Select(sk => sk.FirstOrDefault());
            return skills;
        }
    }
}