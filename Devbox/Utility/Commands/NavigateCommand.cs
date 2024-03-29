﻿using Devbox.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Utility.Commands
{
    internal class NavigateCommand<TViewModel> : CommandBase
    where TViewModel : BaseViewModel
    {
        private readonly INavigator _navigator;
        private readonly Func<TViewModel> _createViewModel;
        public NavigateCommand(INavigator navigator, Func<TViewModel> createViewModel)
        {
            _navigator = navigator;
            _createViewModel = createViewModel;
        }
        public override void Execute(object? parameter)
        {
            _navigator.CurrentViewModel = _createViewModel();
        }
    }
}
