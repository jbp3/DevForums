using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevForums2018.Data.Entities
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public bool IsAcceptedAnswer { get; set; }
        public Question Question { get; set; }
    }
}
