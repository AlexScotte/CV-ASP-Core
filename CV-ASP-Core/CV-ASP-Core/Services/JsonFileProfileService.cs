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
    public class JsonFileProfileService : ServiceBase {

        public Profile Profile { get; private set; }

        public JsonFileProfileService(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment) {

            if (this.Profile == null)
                this.GetProfile();
        }

        public Profile GetProfile() {

            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var json = jsonFileReader.ReadToEnd();
                JObject jObject = JObject.Parse(json);
                JToken jToken = jObject["profile"];
                Profile profile = new Profile();

                if (jToken != null)
                {
                    profile = jToken.ToObject<Profile>();
                    this.Profile = profile;
                }

                return profile;
            }
        }

        public IEnumerable<Skill> GetDistinctSkills() {

            var jsonFileCompanyService = new JsonFileCompanyService(WebHostEnvironment);
            IEnumerable<Skill> skills = jsonFileCompanyService.GetDistinctSkills();
            return skills;
        }
    }
}