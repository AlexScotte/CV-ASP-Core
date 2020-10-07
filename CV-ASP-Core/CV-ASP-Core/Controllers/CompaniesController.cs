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
    public class CompaniesController : ControllerBase {

        private JsonFileCompanyService _companyService { get; set; }

        public CompaniesController(JsonFileCompanyService companyService) {

            _companyService = companyService;
        }

        [HttpGet]
        public IEnumerable<Company> Get() {

            return _companyService.GetCompanies();
        }

        [HttpGet("distinctSkills")]
        public IEnumerable<Skill> GetDistinctSkills()
        {
            return _companyService.GetDistinctSkills();
        }
    }
}