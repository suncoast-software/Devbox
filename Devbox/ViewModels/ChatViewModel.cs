using Devbox.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.ViewModels
{
    internal class ChatViewModel: BaseViewModel
    {
        private List<ChatMessage> _chatMessages;
        public List<ChatMessage> ChatMessages
        {
            get => _chatMessages;
            set => OnPropertyChanged(ref _chatMessages, value);
        }
    }
}
