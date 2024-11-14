using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SemefoApp.BL.Services;
using SemefoApp.Models.Models;

namespace Semefo.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuerpoController(ICuerpoService cuerpoService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<BaseResponseModel>> GetCuerpos()
        {
          var cuerpos = await cuerpoService.GetCuerpos();
          return Ok(cuerpos);
        }
    }
}
