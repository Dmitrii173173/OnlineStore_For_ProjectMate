using OnlineStore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
