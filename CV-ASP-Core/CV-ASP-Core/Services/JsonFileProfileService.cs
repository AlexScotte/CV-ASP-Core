﻿using CV_ASP_Core.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CV_ASP_Core.Services {
    public class JsonFileProfileService : ServiceBase {
        public JsonFileProfileService(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment) {

        }

        public Profile GetFormations() {
            using (var jsonFileReader = File.OpenText(JsonFileName)) {
                var myCV = JsonSerializer.Deserialize<MyCV>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions {
                        PropertyNameCaseInsensitive = true
                    });

                return myCV?.Profile;
            }
        }
    }
}