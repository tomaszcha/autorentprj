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
using ModulesInfrastructure.Views;
using OrderEdit.ViewModels;

namespace OrderEdit.Views
{
    public interface IOrderView : IView
    {
        IOrderViewModel ViewModel { get; set; }
    }
}
