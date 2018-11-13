
using System.Collections.Generic;

namespace NS.Questions.API.Data.Entities
{
    public partial class Questions
    {
        public Questions()
        {
            Answers = new HashSet<Answers>();
        }

        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public ICollection<Answers> Answers { get; set; }
    }
}
