using System;
using System.Linq;
using ModulesInfrastructure.ViewModels;
using ModelMock;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Commands;
using DBMock;
using System.Collections.Generic;
using System.Windows.Input;

namespace AutoPark.ViewModels
{
    public class AutoParkViewModel : ViewModelBase, IAutoParkViewModel
    {
        #region Constructor

        public AutoParkViewModel()
        {
            _models = new ObservableCollection<ModelViewModel>();
            GetListAction(0);
            //_models.CollectionChanged+=OnCollectionChanged;
        }

        #endregion Constructor

        #region Fields

        #region public

        /// <summary>
        /// List of models
        /// </summary>
        public ObservableCollection<ModelViewModel> Models { get { return _models; } }

        #endregion public

        #region private

        private  ObservableCollection<ModelViewModel> _models;

        private DelegateCommand<int> _getListCommand;

        private const int _countOfModelsOnList = 10;

        #endregion private

        #endregion Fields

        #region Commands

        /// <summary>
        /// Get list of models
        /// </summary>
        public ICommand GetListCommand
        {
            get 
            {
                if (_getListCommand == null)
                {
                    _getListCommand = new DelegateCommand<int>(GetListAction);
                }
                return _getListCommand;
            }
        }

        #endregion Commands

        #region Private methods

        private void GetListAction(int number)
        {
            _models.Clear();
            List<ModelViewModel> list = (from model in new Models().List
                        select new ModelViewModel(model)).ToList();
            foreach (ModelViewModel model in list)
            {
                _models.Add(model);
            }
            //foreach (ModelViewModel model in _models)
            //{
            //    model.PropertyChanged += OnModelViewModelPropertyChanged;
            //}
        }

        #endregion Private methods

    }
}
