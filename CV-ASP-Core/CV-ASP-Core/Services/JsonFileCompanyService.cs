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
                return JsonSerializer.Deserialize<Company[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        //public void AddRating(string productId, int rating) {
        //    var products = GetProducts();

        //    if (products.First(x => x.Id == productId).Ratings == null) {
        //        products.First(x => x.Id == productId).Ratings = new int[] { rating };
        //    } else {
        //        var ratings = products.First(x => x.Id == productId).Ratings.ToList();
        //        ratings.Add(rating);
        //        products.First(x => x.Id == productId).Ratings = ratings.ToArray();
        //    }

        //    using (var outputStream = File.OpenWrite(JsonFileName)) {
        //        JsonSerializer.Serialize<IEnumerable<Product>>(
        //            new Utf8JsonWriter(outputStream, new JsonWriterOptions {
        //                SkipValidation = true,
        //                Indented = true
        //            }),
        //            products
        //        );
        //    }
        //}
    }

}