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
    public class JsonFileContactService : ServiceBase {
        public JsonFileContactService(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment) {

        }

        public Contact GetContact() {
            using (var jsonFileReader = File.OpenText(JsonFileName)) {

                var json = jsonFileReader.ReadToEnd();
                JObject jObject = JObject.Parse(json);
                JToken jToken = jObject["contact"];
                Contact contact = new Contact();
                if (jToken != null){

                    contact = jToken.ToObject<Contact>();
                }

                return contact;
            }
        }
    }
}