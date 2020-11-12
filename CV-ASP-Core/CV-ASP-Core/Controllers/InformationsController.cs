using CV_ASP_Core.Models;
using CV_ASP_Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_ASP_Core.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InformationsController
    {

        private JsonFileInformationsService _infoService { get; set; }

        public InformationsController(JsonFileInformationsService infoService)
        {

            _infoService = infoService;
        }

        [HttpGet]
        public Informations Get()
        {

            return _infoService.GetInformations();
        }
    }

}
