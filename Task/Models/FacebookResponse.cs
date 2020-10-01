using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Models
{
    public class FacebookResponse
    {
        public string messaging_type { get; set; }
        public Recipient recipient { get; set; }
        public Message message { get; set; }
    }
}
