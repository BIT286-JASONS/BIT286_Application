﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIT286_Application.Models
{
    public class Question
    {
        public int Difficulty { get; set; }
        public string Question { get; set; }
        public int Answer { get; set; }
    }
}