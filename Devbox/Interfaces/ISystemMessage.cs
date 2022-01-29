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
        SystemMessage SystemMessage { get; set; }

        public event Action? SystemMessageChanged;
        SystemMessage CreateSystemMessage(Guid id, string message, SystemMessageType type, DateTime created);
    }
}
