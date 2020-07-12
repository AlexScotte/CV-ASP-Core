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
    public class FormationsModel : PageModel
    {
        private readonly ILogger<FormationsModel> _logger;
        private readonly JsonFileFormationService _formationService;
        public IEnumerable<Formation> Formations { get; private set; }
        public FormationsModel(ILogger<FormationsModel> logger, JsonFileFormationService formationService) {
            _logger = logger;
            _formationService = formationService;
        }

        public void OnGet() {

            Formations = _formationService.GetFormations();
        }
    }
}