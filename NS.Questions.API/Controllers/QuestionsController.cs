using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NS.Questions.API.Data;
using NS.Questions.API.Data.Services;

namespace NS.Questions.API.Controllers
{
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        // GET api/values
        [Route("api/questions")]
        [HttpGet("[action]")]
        public async Task<List<Data.Entities.Questions>> Questions()
        {
            QuestionService service = new QuestionService(new DataContext());
            return await service.GetAllQuestions();
        }

    }
}
