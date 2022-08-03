using Microsoft.AspNetCore.Mvc;
using POC.Models;
using POC.Services;
using System.Text.Json;

namespace POC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PropostaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(Proposta proposta)
        {
            var keySecret = Request.Headers["KeySecret"];
            if (keySecret == "88209d8937d7351ef62018803e699df4")
            { 
            
                PropostaService.Add(proposta);
                return CreatedAtAction(nameof(Create), new { id = proposta.Id }, proposta);
                
            }
            else
            {
               return Unauthorized();
            }
            //return Ok();
        }

        [HttpPut("{id}/Documento")]
        public IActionResult AddDoc(Documento doc)
        {
            var keySecret = Request.Headers["KeySecret"];
            if (keySecret == "88209d8937d7351ef62018803e699df4")
            {
                string uri = StorageService.UploadDoc(doc);

                return Created(nameof(AddDoc), uri);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
