using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ModulesInfrastructure.ViewModels;
using System.ComponentModel;
using Microsoft.Practices.Prism.Events;
using EventInfrastracture;
using Microsoft.Practices.Prism.Commands;

namespace Menu.ModelViews
{
    public class MenuViewModel  : ViewModelBase, IMenuViewModel
    {

        public MenuViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        private string clickOnMenu;
        private IEventAggregator eventAggregator;


        void OnMenuClick()
        {
            {
                eventAggregator.GetEvent<MenuEvent>().Publish(clickOnMenu);
            }
        }
        private DelegateCommand _onMenuCliclCommand;

        public ICommand OnMenuCliclCommand
        {
            get
            {
                if (_onMenuCliclCommand == null)
                {
                    _onMenuCliclCommand = new DelegateCommand(OnMenuClick);
                }
                return _onMenuCliclCommand;
            }
        }
    }
}
