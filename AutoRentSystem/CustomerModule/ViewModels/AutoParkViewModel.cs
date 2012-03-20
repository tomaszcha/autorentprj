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
        List<Model> list;
        //List<ModelViewModel> list;

        public AutoParkViewModel()
        {
           // _models = new ObservableCollection<ModelViewModel>();
           // _categories = new List<CategoryViewModel>();
           // _number = 1;
           // GetListPrevAction();
           // GetListOfCategories();
            //_countOfDataInList = new Models().List.Count;
            //_models.CollectionChanged+=OnCollectionChanged;
          
            
            list = new List<Model> {
                new Model                      
                {
                    Id = 1,
                    Make = new Make() {Id = 1, Name = "Mazda"},
                    Name = "CX-5",
                    Engine = "2",
                    Seats = 5,
                    DayRate = 700,
                    KmRate = 10,
                    Deposit = 0
                },
                new Model
                    {
                        Id = 2,
                        Make = new Make() {Id = 1, Name = "Opel"},
                        Name = "Antara",
                        Engine = "2.2",
                        Seats = 5,
                        DayRate = 900,
                        KmRate = 12,
                        Deposit = 0
                    },
                new Model
                    {
                        Id = 3,
                        Make = new Make() {Id = 1, Name = "Lexus"},
                        Name = "Es",
                        Engine = "2",
                        Seats = 5,
                        DayRate = 1100,
                        KmRate = 15,
                        Deposit = 1100
                    },
                new Model
                    {
                        Id = 4,
                        Make = new Make() {Id = 1, Name = "Lexus"},
                        Name = "Es4",
                        Engine = "2",
                        Seats = 5,
                        DayRate = 2000,
                        KmRate = 20,
                        Deposit = 3000
                    }
            };
           /* _models.Clear();
           
            list = (from model in new Models().List
                                       select new ModelViewModel(model)).ToList();
            foreach (ModelViewModel model in list)
            {
                _models.Add(model);
            }
           /* List<ModelViewModel> list = (from model in new Models().List
                                       select new ModelViewModel(model)).ToList();
            foreach (ModelViewModel model in list)
            {
                _models.Add(model);
            }*/
        }

        #endregion Constructor

        #region Fields

        #region public

        /// <summary>
        /// List of models
        /// </summary>
       // public ObservableCollection<ModelViewModel> Models { get { return _models; } }
        public List<Model> Models { get { return  list;} }
          
        /// <summary>
        /// List of categories
        /// </summary>
       // public List<CategoryViewModel> Categoreis { get { return _categories; } }

        #endregion public

        #region private

       // private ObservableCollection<ModelViewModel> _models;

       // private List<CategoryViewModel> _categories;

       // private DelegateCommand _getListNextCommand;

        //private DelegateCommand _getListPrevCommand;

       // private const int _countOfModelsOnList = 3;

       // private int _number = 0;

       // private int _countOfDataInList;

        #endregion private

        #endregion Fields
        /*
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
        /*
        private void GetListOfCategories()
        {
            _categories.Clear();
            _categories = (from category in new Categories().List
                                            select new CategoryViewModel(category)).ToList();
        }
        
        #endregion Private methods*/

    }
}
