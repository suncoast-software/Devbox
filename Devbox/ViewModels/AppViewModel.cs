using Devbox.Data.Factories;
using Devbox.Interfaces;
using Devbox.Services;
using Devbox.Utility;
using Devbox.Utility.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Devbox.ViewModels
{
    internal class AppViewModel: BaseViewModel, IDisposable
    {
        private readonly IDataService? _dataService;
        private readonly AppDbContextFactory? _dbFactory;
        private readonly INavigator? _navigator;
        private ISystemMessage? _systemMessage;
        public BaseViewModel? CurrentViewModel => _navigator.CurrentViewModel;
        public ISystemMessage? SystemMessage => (ISystemMessage?)_systemMessage.SystemMessage;
        public AppViewModel(IDataService? dataService, AppDbContextFactory? dbFactory, INavigator? navigator, ISystemMessage systemMessage)
        {
            _dataService = dataService;
            _dbFactory = dbFactory;
            _navigator = navigator;
            _systemMessage = systemMessage;
            _navigator.CurrentViewModelChanged += OnCurrentViewModelChanged;
            _systemMessage.SystemMessageChanged += OnSystemMessageChanged;
        }

        private void OnSystemMessageChanged()
        {
            throw new NotImplementedException();
        }

        private void OnCurrentViewModelChanged()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _navigator.CurrentViewModelChanged -= OnCurrentViewModelChanged;
            _systemMessage.SystemMessageChanged -= OnSystemMessageChanged;
        }
    }
}
