using Devbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Interfaces
{
    internal interface ISystemMessage
    {
        SystemMessageType MessageType { get; set; }
        SystemMessage SystemMessage { get; set; }
        SystemMessage CreateSystemMessage(Guid id, string message, SystemMessageType type, DateTime created);
    }
}
