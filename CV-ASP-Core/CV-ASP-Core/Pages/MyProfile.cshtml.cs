using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CV_ASP_Core.Models;
using CV_ASP_Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CV_ASP_Core.Pages {
    public class ProfileModel : PageModel {

        private readonly ILogger<ProfileModel> _logger;
        private readonly JsonFileProfileService _profileService;
        public Profile Profile { get; set; }
        public IEnumerable<Skill> Skills { get; set; }

        public ProfileModel(ILogger<ProfileModel> logger, JsonFileProfileService profileService) {
            _logger = logger;
            _profileService = profileService;
        }

        public virtual void OnGet() {

            Profile = _profileService.GetProfile();
            Skills = _profileService.GetDistinctSkills();
        }
    }
}