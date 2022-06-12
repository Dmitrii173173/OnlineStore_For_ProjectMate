using MathCore.Collections.Interfaces;
using OnlineShopLib.Entityes;
using OnlineStore.Infrastructure.Commands;
using OnlineStore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IRepository<Client> _ClientRepository;

        /// <summary> статус  </summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        public MainWindowViewModel(IRepository<Client> ClientRepository)
        {
            _ClientRepository = ClientRepository;
            var product = ClientRepository.Items.Take(10).ToArray();
        }
    }
}
