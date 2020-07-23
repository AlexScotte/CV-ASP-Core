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
    public class ContactController {

        private JsonFileContactService _contactService { get; set; }

        public ContactController(JsonFileContactService contactService) {

            _contactService = contactService;
        }

        [HttpGet]
        public Contact Get() {

            return _contactService.GetContact();
        }
    }
}
