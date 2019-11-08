using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColleguesApi.Controllers.DTO;
using ColleguesApi.Models;
using ColleguesApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ColleguesApi.Controllers
{
    [Route("[controller]")]
    public class CollegueController : Controller
    {

        private readonly ICollegueService _collegueService;

        public CollegueController(ICollegueService collegueService)
        {
            _collegueService = collegueService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> RecupererMatriculeParNom(string nom)
        {
            
            return _collegueService.RechercheParNom(nom);
        }

        [HttpGet("{matricule}")]
        public IActionResult RecupererCollegueParMatricule(string matricule)
        {
            try
            {
                return Ok(_collegueService.RechercheParMatricule(matricule));
            }
            catch (ColleguesApi.Exceptions.CollegueNonTrouveException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreerCollegue([FromBody] CreationColleguePostDTO creationColleguePostDTO)
        {
            return Ok(_collegueService.CreationCollegue(creationColleguePostDTO));
        }


    }
}
