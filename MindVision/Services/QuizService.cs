using MindVision.Data;
using MindVision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MindVision.Services
{
    public class QuizService
    {
        private readonly ApplicationDbContext _dbContext;

        public QuizService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        
        public async Task<List<Question>> GetQuestionsAsync()
        {
            await Task.Delay(1000);

            var sQ1 = new SubQuestion[]
            {
                new SubQuestion("-5",TimeSpan.FromMilliseconds(2000)),
                new SubQuestion("5",TimeSpan.FromMilliseconds(1500)),
                new SubQuestion("15",TimeSpan.FromMilliseconds(1000)),
                new SubQuestion("-2",TimeSpan.FromMilliseconds(1500)),
                new SubQuestion("-19",TimeSpan.FromMilliseconds(1000)),
                new SubQuestion("-3",TimeSpan.FromMilliseconds(1500)),
                new SubQuestion("2",TimeSpan.FromMilliseconds(2000)),
                new SubQuestion("5",TimeSpan.FromMilliseconds(1500)),
                new SubQuestion("6",TimeSpan.FromMilliseconds(1000)),
                new SubQuestion("3",TimeSpan.FromMilliseconds(2000)),
                new SubQuestion("-10",TimeSpan.FromMilliseconds(1500)),
            };


            var sQ2 = new SubQuestion[]
            {
                new SubQuestion("-3",TimeSpan.FromMilliseconds(2000)),
                new SubQuestion("7",TimeSpan.FromMilliseconds(1500)),
                new SubQuestion("20",TimeSpan.FromMilliseconds(1000)),
                new SubQuestion("-10",TimeSpan.FromMilliseconds(1500)),
            };

            return new List<Question>()
            {
                new Question("Question 1","This is a Question ?","-5",sQ1){ Id = 0},
                new Question("Question 2","This is a Question ?","14",sQ2){ Id = 1},
                new Question("Question 3","This is a Question ?","-5",sQ1){ Id = 2},
                new Question("Question 4","This is a Question ?","14",sQ2){ Id = 3},
                new Question("Question 5","This is a Question ?","-5",sQ1){ Id = 4},
            };
        }

    }
}
