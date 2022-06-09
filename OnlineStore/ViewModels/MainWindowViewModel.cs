using OnlineStore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Подписки или постоянные лицензии на ПО";
        /// <summary> Заголовок окна </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
