
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NS.Questions.API.Data.Services
{
    public interface IQuestionService
    {
        Task<List<Entities.Questions>> GetAllQuestions();
    }
}
