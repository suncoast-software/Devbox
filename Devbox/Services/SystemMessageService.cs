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
        public SystemMessage? SystemMessage { get; set; }

        public event Action? SystemMessageChanged;

        private SystemMessage? _globalSystemMessage;
        public SystemMessage? GlobalSystemMessage
        {
            get => _globalSystemMessage;
            set
            {
                _globalSystemMessage = value;
                OnSystemMessageChanged();
            }
        }

       

        public SystemMessage CreateSystemMessage(Guid id, string message, SystemMessageType type, DateTime created)
        {
            throw new NotImplementedException();
        }

        private void OnSystemMessageChanged()
        {
            SystemMessageChanged?.Invoke();
        }
    }
}
