using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class CreateMessagseDto
    {
        public string? RecipientUsername { get; set; }
        public string? Content { get; set; }
    }
}