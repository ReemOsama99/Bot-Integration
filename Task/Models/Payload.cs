using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Payload
    {
        public string template_type { get; set; }
        public List<Element> elements { get; set; }
       
    }
}
