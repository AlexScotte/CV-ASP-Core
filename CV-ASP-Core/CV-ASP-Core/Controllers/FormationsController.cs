using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CV_ASP_Core.Models;
using CV_ASP_Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CV_ASP_Core.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class FormationsController : ControllerBase {

        private JsonFileFormationService _formationService { get; set; }

        public FormationsController(JsonFileFormationService formationService) {

            _formationService = formationService;
        }

        [HttpGet]
        public IEnumerable<Formation> Get() {

            return _formationService.GetFormations();
        }
    }
}