using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Modal.Login.Models
{
    public class SessionModel
    {
        public string Pin { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
