using DevForums2018.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevForums2018.Services
{
    public interface IQuestionService
    {
        Task<List<Question>> GetAllQuestions();
    }
}
