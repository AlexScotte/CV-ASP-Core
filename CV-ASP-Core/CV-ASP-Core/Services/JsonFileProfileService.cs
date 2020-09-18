using CV_ASP_Core.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CV_ASP_Core.Services {
    public class JsonFileProfileService : ServiceBase {

        public MyCV MyCV { get; private set; }
        public Profile Profile { get; private set; }

        public JsonFileProfileService(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment) {

            using (var jsonFileReader = File.OpenText(JsonFileName)) {
                var myCV = JsonSerializer.Deserialize<MyCV>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions {
                        PropertyNameCaseInsensitive = true
                    });

                MyCV = myCV;
            }
        }

        public Profile GetProfile() {

                return MyCV?.Profile;
        }

        public IEnumerable<Skill> GetDistinctSkills() {

            IEnumerable<Skill> skills = MyCV.Companies.SelectMany(co => co.Clients).SelectMany(cl => cl.Experience.Skills).Where(sk => sk.Important == 1).GroupBy(sk => sk.Name).Select(sk => sk.FirstOrDefault());
            return skills;
        }
    }
}