using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : ControllerBase
    {
        private readonly IMegasenaService _megaService;

        public MegaSenaController(IMegasenaService IMegaSenaService)
        {
            _megaService = megaService;
        }

        [HttpPost(Name = "Adicionar")]
        public IActionResult Post(MegaSenaViewModel MegaSenaViewModel)
        {
            _IMegaSenaService.Adicionar(MegaSenaViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodos")]
        public IActionResult Get()
        {
            return Ok(_megaService.ObterTodos());
        }

        
    }
}
