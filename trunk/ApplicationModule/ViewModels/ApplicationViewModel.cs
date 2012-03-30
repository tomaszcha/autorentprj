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
using ApplicationModule.Events;
using CommandsInfrastracture;
using EventInfrastracture;
using Microsoft.Practices.Prism.Commands;

namespace ApplicationModule.ViewModels
{
    /// <summary>
    /// This class contains properties that an ApplicationView can data bind to
    /// </summary>   
    public class ApplicationViewModel : ViewModelBase, IApplicationViewModel, IDataErrorInfo
    {


        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
