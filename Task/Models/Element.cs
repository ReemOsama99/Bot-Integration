﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Element
    {
        public string title { get; set; }
        public string image_url { get; set; }
        public string subtitle { get; set; }
        public DefaultAction default_action { get; set; }
        //public Button buttons { get; set; }
        public List<Button> buttons { get; set; }
    }
}
