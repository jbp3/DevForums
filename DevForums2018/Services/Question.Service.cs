using DevForums2018.Data;
using DevForums2018.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevForums2018.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly DataContext _context;
        public QuestionService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Question>> GetAllQuestions()
        {

            var questions = (from q in _context.Questions select q);
            return await Task.FromResult(questions.ToList());

        }
        
    }
}
