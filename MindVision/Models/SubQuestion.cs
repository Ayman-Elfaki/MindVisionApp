using System;
using System.Collections.Generic;

using MindVision.Models.Common;

namespace MindVision.Models
{
    public class SubQuestion : ValueObject
    {
        private SubQuestion() { }
        public SubQuestion(string content, TimeSpan duration)
        {
            Content = content;
            Duration = duration;
        }

        public string Content { get; set; }
        public TimeSpan Duration { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Content;
            yield return Duration;
        }
    }
}
