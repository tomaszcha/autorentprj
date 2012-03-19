using System;
using System.Linq;
using ModulesInfrastructure.ViewModels;
using ModelMock;
using System.Collections.ObjectModel;
using DBMock;
using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace CustomerModule.ViewModels
{
    public class AutoParkViewModel : ViewModelBase, IAutoParkViewModel
    {
        #region Constructor

        public AutoParkViewModel()
        {
            _models = new ObservableCollection<ModelViewModel>();
            _categories = new List<CategoryViewModel>();
            _number = 1;
            GetListPrevAction();
            GetListOfCategories();
            _countOfDataInList = new Models().List.Count;
            //_models.CollectionChanged+=OnCollectionChanged;
        }

        #endregion Constructor

        #region Fields

        #region public

        /// <summary>
        /// List of models
        /// </summary>
        public ObservableCollection<ModelViewModel> Models { get { return _models; } }

        /// <summary>
        /// List of categories
        /// </summary>
        public List<CategoryViewModel> Categoreis { get { return _categories; } }

        #endregion public

        #region private

        private  ObservableCollection<ModelViewModel> _models;

        private List<CategoryViewModel> _categories;

        private DelegateCommand _getListNextCommand;

        private DelegateCommand _getListPrevCommand;

        private const int _countOfModelsOnList = 3;

        private int _number = 0;

        private int _countOfDataInList;

        #endregion private

        #endregion Fields

        #region Commands

        /// <summary>
        /// Get list of models
        /// </summary>
        public ICommand GetListNextCommand
        {
            get 
            {
                if (_getListNextCommand == null)
                {
                    _getListNextCommand = new DelegateCommand(GetListNextAction, CanGetNextListAction);
                }
                return _getListNextCommand;
            }
        }

        public ICommand GetListPrevtCommand
        {
            get
            {
                if (_getListPrevCommand == null)
                {
                    _getListPrevCommand = new DelegateCommand(GetListPrevAction, CanGetPrevtListAction);
                }
                return _getListPrevCommand;
            }
        }

        #endregion Commands

        #region Private methods

        private void GetListNextAction()
        {
            _number++;
            GetListAction();
        }

        private bool CanGetNextListAction()
        {
            bool res = true;
            if ((_number + 1) * _countOfModelsOnList == _countOfDataInList) res = false;
            return res;
        }

        private void GetListPrevAction()
        {
            _number--;
            GetListAction();
        }

        private bool CanGetPrevtListAction()
        {
            bool res = true;
            if (_number==0) res = false;
            return res;
        }

        private void GetListAction()
        {
            _models.Clear();
            List<ModelViewModel> list = (from model in new Models().List.GetRange(_number * _countOfModelsOnList, _countOfModelsOnList)
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

        private void GetListOfCategories()
        {
            _categories.Clear();
            _categories = (from category in new Categories().List
                                            select new CategoryViewModel(category)).ToList();
        }

        #endregion Private methods

    }
}
