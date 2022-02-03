using Devbox.Data.Factories;
using Devbox.Interfaces;
using Devbox.Models;
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
        public ICommand ExitAppCommand { get; set; }
        public BaseViewModel? CurrentViewModel => _navigator.CurrentViewModel;
        public ISystemMessage? SystemMessage => (ISystemMessage?)_systemMessage.SystemMessage;

        private string _currentStatus = "Online";
        public string CurrentStatus
        {
            get => _currentStatus;
            set => OnPropertyChanged(ref _currentStatus, value);
        }

        private User _currentUser;
        public User CurrentUser
        {
            get => _currentUser;
            set => OnPropertyChanged(ref _currentUser, value);
        }

        public AppViewModel(IDataService? dataService, AppDbContextFactory? dbFactory, INavigator? navigator, ISystemMessage systemMessage)
        {
            _dataService = dataService;
            _dbFactory = dbFactory;
            _navigator = navigator;
            _systemMessage = systemMessage;
            _navigator.CurrentViewModelChanged += OnCurrentViewModelChanged;
            _systemMessage.SystemMessageChanged += OnSystemMessageChanged;
            ExitAppCommand = new RelayCommand(ExitApp);
            //CurrentStatus = "Online";
            User user = new();
            user.Id = Guid.NewGuid();
            user.Username = "Async(void)";
            user.ImageUrl = "";
            CurrentUser = user;
        }

        private void ExitApp()
        {
            Dispose();
            Environment.Exit(0);
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
