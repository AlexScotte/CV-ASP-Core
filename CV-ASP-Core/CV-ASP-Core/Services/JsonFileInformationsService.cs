using CV_ASP_Core.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Services
{
    public class JsonFileInformationsService : ServiceBase
    {

        public Informations Informations { get; private set; }

        public JsonFileInformationsService(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment)
        {
            this.GetInformations();
        }

        public Informations GetInformations()
        {

            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var json = jsonFileReader.ReadToEnd();
                JObject jObject = JObject.Parse(json);
                JToken jToken = jObject["informations"];
                Informations informations = new Informations();

                if (jToken != null)
                {
                    informations = jToken.ToObject<Informations>();
                    this.Informations = informations;
                }

                return informations;
            }
        }
    }
}
