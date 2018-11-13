using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NS.Questions.API.Data.Entities;

namespace NS.Questions.API.Data.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly DataContext _context;
        public QuestionService(DataContext context)
        {
            _context = context;
        }
 
        public async Task<List<Entities.Questions>> GetAllQuestions()
        {
            var questions = (from q in _context.Questions select q);
            return await Task.FromResult(questions.ToList());
        }
    }
}
