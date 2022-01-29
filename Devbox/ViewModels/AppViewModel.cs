using Devbox.Data.Factories;
using Devbox.Interfaces;
using Devbox.Services;
using Devbox.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.ViewModels
{
    internal class AppViewModel: BaseViewModel, IDisposable
    {
        private readonly IDataService? _dataService;
        private readonly AppDbContextFactory? _dbFactory;
        private readonly INavigator? _navigator;
        public BaseViewModel? CurrentViewModel => _navigator.CurrentViewModel;
        public AppViewModel(IDataService? dataService, AppDbContextFactory? dbFactory, INavigator? navigator)
        {
            _dataService = dataService;
            _dbFactory = dbFactory;
            _navigator = navigator;

            _navigator.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _navigator.CurrentViewModelChanged -= OnCurrentViewModelChanged;
        }
    }
}
