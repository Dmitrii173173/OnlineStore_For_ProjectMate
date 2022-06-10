using OnlineStore.Infrastructure.Commands;
using OnlineStore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace OnlineStore.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Online Store For Soft Traid Plus";
        /// <summary> Заголовок окна </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }


        private string _Status = "Ready!";
        /// <summary> статус  </summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecuted(object p) => true;
        private void OnCloseApplicationCommandExecute (object p)
        {
            Application.Current.Shutdown();
        }
        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecuted);
        }
    }
}
