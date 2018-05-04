﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quizlabb.Models_
{
    public class AnswerOption
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string CorrectAnswer { get; set; }

    }
}
