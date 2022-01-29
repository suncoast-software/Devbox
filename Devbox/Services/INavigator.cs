using Devbox.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Services
{
    internal class INavigator
    {
        public event Action? CurrentViewModelChanged;
        public BaseViewModel? CurrentViewModel { get; set; }
    }
}
