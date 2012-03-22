﻿using System;
using System.Linq;
using ModulesInfrastructure.ViewModels;
using ModelMock;
using System.Collections.ObjectModel;
using DBMock;
using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Data;
using System.Reflection;
using Microsoft.Practices.Prism.Events;
using CustomerModule.Events;

namespace CustomerModule.ViewModels
{
    
    public class AutoParkViewModel : ViewModelBase, IAutoParkViewModel
    {
        public enum Category { Economy, Middle, Luxury };        

        ObservableCollection<string> _categories;
        PagedCollectionView _pagedModels;

        #region Constructor


        public AutoParkViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            
            _models = new ObservableCollection<ModelViewModel>();
            GetListAction(0);
           
            _pagedModels = new PagedCollectionView(_models);            
            if (_pagedModels.CanGroup == true)
            {
                _pagedModels.GroupDescriptions.Add(new PropertyGroupDescription("Make.Name"));
            }            

            _categories = new ObservableCollection<string>();
            Type typeCategory = typeof(Category);
            FieldInfo[] arrCategFieldValues = typeCategory.GetFields(BindingFlags.Public | BindingFlags.Static);
            foreach (var categName in arrCategFieldValues)
            {
                Categories.Add(categName.GetValue(null).ToString());
            }
        }

        #endregion Constructor
        
        public ObservableCollection<string> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        public ModelViewModel CurModel { get; set; }

        /// <summary>
        /// List of models
        /// </summary>
        public PagedCollectionView Models { get { return _pagedModels; } }
               
        #region private

        private  ObservableCollection<ModelViewModel> _models;

        private DelegateCommand<int> _getListCommand;   
    
        #endregion private
        
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
        }
        #endregion Private methods


        IEventAggregator eventAggregator;
        DelegateCommand _selectCommand;

        #region Commands
       
        public ICommand SelectCommand
        {
            get
            {
                if (_selectCommand == null)
                    _selectCommand = new DelegateCommand(SelectModel);
                return _selectCommand;
            }
        }

        #endregion Commands

        public void SelectModel()
        {
            eventAggregator.GetEvent<SelectEvent>().Publish(CurModel);
        }
       
        /*
         * 
        #region Constructor

        public enum Category{ Economy, Middle, Luxury };

        ObservableCollection<string> _categories;

        public AutoParkViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            pList = new PagedCollectionView(GetListOfModels());
            if (pList.CanGroup == true)
            {
                pList.GroupDescriptions.Add(new PropertyGroupDescription("Make.Name"));
            }

            _categories = new ObservableCollection<string>();

            Type typeCategory = typeof(Category);
            FieldInfo[] arrCategFieldValues = typeCategory.GetFields(BindingFlags.Public|BindingFlags.Static);
            foreach(var categName in arrCategFieldValues)
            {
                Categories.Add(categName.GetValue(null).ToString());
            }
           
        }

        #endregion Constructor

        public ObservableCollection<string> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        #region Help method
        
        private List<Model> GetListOfModels()
        {
            return new List<Model> {
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
                    },
                new Model                      
                {
                        Id = 5,
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
                        Id = 6,
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
                        Id = 7,
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
                        Id = 8,
                        Make = new Make() {Id = 1, Name = "Lexus"},
                        Name = "Es4",
                        Engine = "2",
                        Seats = 5,
                        DayRate = 2000,
                        KmRate = 20,
                        Deposit = 3000
                    },
                new Model                      
                {
                        Id = 9,
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
                        Id = 10,
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
                        Id = 11,
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
                        Id = 12,
                        Make = new Make() {Id = 1, Name = "Lexus"},
                        Name = "Es4",
                        Engine = "2",
                        Seats = 5,
                        DayRate = 2000,
                        KmRate = 20,
                        Deposit = 3000
                    },
                new Model
                    {
                        Id = 13,
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
                        Id = 14,
                        Make = new Make() {Id = 1, Name = "Opel"},
                        Name = "Omega",
                        Engine = "2",
                        Seats = 5,
                        DayRate = 1000,
                        KmRate = 30,
                        Deposit = 1000
                    }
            };
        }

        public void SelectModel()
        {
            eventAggregator.GetEvent<SelectEvent>().Publish(new ModelViewModel(CurModel));
        }

        #endregion
       
        #region Fields

        #region public

        /// <summary>
        /// List of models
        /// </summary>
        // public ObservableCollection<ModelViewModel> Models { get { return _models; } }
        public PagedCollectionView Models { get { return pList; } }

        public Model CurModel { get; set; }

        #endregion public

        #region private

        List<Model> list;

        PagedCollectionView pList;

        IEventAggregator eventAggregator;

        DelegateCommand _selectCommand;

        // private ObservableCollection<ModelViewModel> _models;

        // private List<CategoryViewModel> _categories;

        // private DelegateCommand _getListNextCommand;

        //private DelegateCommand _getListPrevCommand;

        // private const int _countOfModelsOnList = 3;

        // private int _number = 0;

        // private int _countOfDataInList;

        #endregion private

        #endregion Fields 
     
        #region Commands

        public ICommand SelectCommand
        {
            get 
            {
                if (_selectCommand == null)
                    _selectCommand = new DelegateCommand(SelectModel);
                return _selectCommand;
            }
        }

        #endregion Commands*/
    }
}
