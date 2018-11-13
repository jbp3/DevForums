
namespace NS.Questions.API.Data.Entities
{
    public partial class Answers
    {
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public bool IsAcceptedAnswer { get; set; }

        public Questions Question { get; set; }
    }
}
