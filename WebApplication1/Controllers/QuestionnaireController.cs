using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Classes;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("/[controller]")]
    public class QuestionnaireController : ControllerBase
    {

        [Authorize]
        [HttpGet("getQuestionnaire")]
        public IActionResult GetQuestionnaire()
        {
            List<Question> questions = Questionnaire.CreateQuestionnaire();   
            return Ok(questions);
        }
    }
}
