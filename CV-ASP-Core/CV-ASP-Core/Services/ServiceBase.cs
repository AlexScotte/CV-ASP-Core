using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Services {
    public class ServiceBase {

        public ServiceBase(IWebHostEnvironment webHostEnvironment) {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        protected string JsonFileName {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "cv-data.json"); }
        }
    }
}
