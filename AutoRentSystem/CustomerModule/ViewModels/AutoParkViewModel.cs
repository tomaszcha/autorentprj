using System;
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
       
    }
}
