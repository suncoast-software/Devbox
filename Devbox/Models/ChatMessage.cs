using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Models
{
    internal class ChatMessage
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public ChatMessage Message { get; set; }
        public DateTime Created { get; set; }
    }
}
