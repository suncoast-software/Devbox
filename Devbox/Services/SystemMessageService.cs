using Devbox.Interfaces;
using Devbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Services
{
    internal class SystemMessageService : ISystemMessage
    {
        public SystemMessageType MessageType { get; set; }
        public SystemMessage SystemMessage { get; set; }

        public SystemMessage CreateSystemMessage(Guid id, string message, SystemMessageType type, DateTime created)
        {
            throw new NotImplementedException();
        }
    }
}
