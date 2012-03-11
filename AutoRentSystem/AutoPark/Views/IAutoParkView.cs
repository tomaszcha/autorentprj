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
using AutoPark.ViewModels;
using ModulesInfrastructure.Views;

namespace AutoPark.Views
{
    public interface IAutoParkView : IView
    {
        IAutoParkViewModel ViewModel { get; set; }
    }
}
