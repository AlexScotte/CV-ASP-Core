using CV_ASP_Core.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CV_ASP_Core.Services {
    public class JsonFileCompanyService {
        public JsonFileCompanyService(IWebHostEnvironment webHostEnvironment) {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "cv-data.json"); }
        }

        public IEnumerable<Company> GetCompanies() {
            using (var jsonFileReader = File.OpenText(JsonFileName)) {
                var myCV = JsonSerializer.Deserialize<MyCV>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions {
                        PropertyNameCaseInsensitive = true
                    });

                return myCV?.Companies;
            }
        }
    }
}