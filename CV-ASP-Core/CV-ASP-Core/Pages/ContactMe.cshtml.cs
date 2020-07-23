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
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        private readonly JsonFileContactService _contactService;
        public Contact Contact { get; private set; }
        public ContactModel(ILogger<ContactModel> logger, JsonFileContactService contactService) {
            _logger = logger;
            _contactService = contactService;
        }

        public void OnGet() {

            Contact = _contactService.GetContact();
        }

        public string FormatLink(string url) {

            if (string.IsNullOrEmpty(url) && string.IsNullOrWhiteSpace(url))
                return string.Empty;

            var newUrl = url.ToLower().Replace("http://", "").Replace("https://", "").Replace("www.", "");
            return newUrl;
        }
    }
}