using CV_ASP_Core.Models;
using CV_ASP_Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class ProfileController {

        private JsonFileProfileService _profileService { get; set; }

        public ProfileController(JsonFileProfileService profileService) {

            _profileService = profileService;
        }

        [HttpGet]
        public Profile Get() {

            return _profileService.GetProfile();
        }
    }
}
