using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Models
{
    internal class SystemMessage
    {
        public Guid Id { get; set; }
        public string? Message { get; set; }
        public SystemMessageType MessageType { get; set; }
        public DateTime Created { get; set; }

    }
}
