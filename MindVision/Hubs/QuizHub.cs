using Microsoft.AspNetCore.SignalR;
using MindVision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindVision.Hubs
{
    public class QuizHub : Hub
    {
        public const string HubUrl = "/quiz-hub";
        public async Task SendQuestion(Question question)
        {
            await Clients.Others.SendAsync("OnReceiveQuestion", question);
        }

        public async Task StartQuiz(SubQuestion subQuestion)
        {
            await Task.Delay((int)subQuestion.Duration.TotalMilliseconds);
            await Clients.Others.SendAsync("OnStartQuiz", subQuestion.Content);
        }
    }
}
