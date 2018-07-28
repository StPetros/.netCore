using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Modal.Models
{
    public class Credentials
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pin { get; set; }
        public DateTime SessionStart { get; set; }
    }
}