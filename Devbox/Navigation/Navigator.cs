﻿using Devbox.Models;
using Devbox.Services;
using Devbox.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Navigation
{
    internal class Navigator : INavigator
    {
        public event Action? CurrentViewModelChanged;

        public event Action? SystemMessageChanged;

        private BaseViewModel? _currentViewModel;
        public BaseViewModel? CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
