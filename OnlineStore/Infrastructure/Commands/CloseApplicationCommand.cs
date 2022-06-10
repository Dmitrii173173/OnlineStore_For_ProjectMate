using OnlineStore.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace OnlineStore.Infrastructure.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
