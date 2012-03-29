﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ModuleInfrastracture.ViewModels;
using System.ComponentModel;
using System.Text.RegularExpressions;
using MockModel;
using Microsoft.Practices.Prism.Events;
using OrderModule.Events;
using CommandsInfrastracture;
using EventInfrastracture;
using Microsoft.Practices.Prism.Commands;

namespace OrderModule.ViewModels
{
    public class OrdersListViewModel : ViewModelBase, IOrdersListViewModel
    {

    }
}
