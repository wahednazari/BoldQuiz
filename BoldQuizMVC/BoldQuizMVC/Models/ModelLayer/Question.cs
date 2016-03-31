﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoldQuizMVC.Models
{
    public class Question
    {
        public string Title { get; set; }
        public string Point { get; set; }
        public string QuestionText { get; set; }
        public Category Category { get; set; }
        public List<Answer> Answers { get; set; }
    }
}