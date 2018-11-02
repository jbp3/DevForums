using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevForums2018.Data;
using DevForums2018.Data.Entities;
using DevForums2018.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevForums2018.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
     

        [HttpGet("[action]")]
        public async Task<List<Question>> Questions()
        {
            QuestionService service = new QuestionService(new DataContext());
            return await service.GetAllQuestions();
        }

    }
}
