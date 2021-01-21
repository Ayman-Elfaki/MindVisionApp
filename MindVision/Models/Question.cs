using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MindVision.Models.Common;

namespace MindVision.Models
{
    public class Question : Entity
    {
        private Question() { }
        public Question(string title, string description, string answer, IList<SubQuestion> subQuestions)
        {
            Title = title;
            Description = description;
            Answer = answer;
            SubQuestions = subQuestions;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        public IList<SubQuestion> SubQuestions { get; private set; }


        public string GetSubQuestionsStringRepresentation()
        {
            return string.Join(", ", SubQuestions.Select(s => s.Content));
        }
     
    }
}
