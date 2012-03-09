using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace OrderEdit.ViewModels
{
    /// <summary>
    /// Provides base class for view models  
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged, IDisposable
    {

        #region Implementetion of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        #endregion

        #region Implementation of IDisposable

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose() { }

        #endregion
    }
}
