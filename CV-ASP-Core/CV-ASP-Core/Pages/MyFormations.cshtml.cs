using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CV_ASP_Core.Models;
using CV_ASP_Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CV_ASP_Core.Pages
{
    public class FormationsModel : ProfileModel
    {
        private readonly ILogger<FormationsModel> _logger;
        private readonly JsonFileFormationService _formationService;

        public IEnumerable<Formation> Formations { get; private set; }


        public FormationsModel(ILogger<FormationsModel> logger, JsonFileFormationService formationService, ILogger<ProfileModel> baseLogger, JsonFileProfileService profilService) : base(baseLogger, profilService) {
            _logger = logger;
            _formationService = formationService;
        }

        public override void OnGet() {

            base.OnGet();
            Formations = _formationService.GetFormations();
        }
    }
}