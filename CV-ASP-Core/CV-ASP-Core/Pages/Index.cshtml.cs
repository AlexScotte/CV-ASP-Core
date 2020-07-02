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
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        private readonly JsonFileCompanyService _companyService;
        public IEnumerable<Company> Companies { get; private set; }
        public IndexModel(ILogger<IndexModel> logger, JsonFileCompanyService companyService) {
            _logger = logger;
            _companyService = companyService;
        }

        public void OnGet() {

            Companies = _companyService.GetCompanies();
        }
    }
}
