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
using ModuleInfrastracture.ViewModels;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Commands;
using MockModel;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Prism.Events;
using AutoModule.Events;

namespace AutoModule.ViewModels
{
    public class AutosListViewModel : ViewModelBase, IAutosListViewModel
    {
        #region Constructor

        public AutosListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _autos = new ObservableCollection<AutoViewModel>();
            GetAutosList();
        }

        #endregion Constructor

        #region Private fields

        private ObservableCollection<AutoViewModel> _autos;

        private AutoViewModel _curAuto;

        IEventAggregator _eventAggregator;

        //private DelegateCommand 

        #endregion PrivateFields

        #region Properties

        public ObservableCollection<AutoViewModel> Auto
        {
            get { return _autos; }
            set { _autos = value; }
        }

        public AutoViewModel CurAuto
        {
            get { return _curAuto; }
            set
            {
                _curAuto = value;
                onAutoSelect(value);
            }
        }

        #endregion Properties

        #region Commands

        #endregion Commands

        #region Helpers

        private void GetAutosList()
        {
            _autos.Clear();
            List<AutoViewModel> list = (from model in new Autos().List
                                            select new AutoViewModel(model, _eventAggregator)).ToList();
            foreach (AutoViewModel model in list)
            {
                _autos.Add(model);
            }
        }

        private void onAutoSelect(AutoViewModel auto)
        {
            _eventAggregator.GetEvent<AutoSelect>().Publish(auto);
        }

        #endregion Helpers

    }
}
