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
using ModelMock;
using System.Collections.Generic;

namespace ServerMock
{
    public class Commands
    {
        #region Commands

        public static List<IBaseClass> GetCommand(string type, int indexFrom, int indexTo)
        {
            List<IBaseClass> list;
            switch (type)
            {
                case Types.Model:
                    list = GetModelList(indexFrom, indexTo);
                    break;
            }  
        }

        public static bool InsertCommand(object item)
        {
            bool res = true;
            string type = item.GetType().ToString();
            switch (type)
            {
                case Types.Model:
                    res = InsertModel(item as Model);
                    break;
            }
            return res;
        }

        #endregion Commands

        #region Private Methods

        private static bool InsertModel(Model model)
        {
            return true;
        }

        private static List<Model> GetModelList(int indexFrom, int indexTo)
        {
            return new List<Model>();
            //if (indexTo >= _models.Count || indexFrom < 0)
            //    throw new IndexOutOfRangeException();
            //if (indexFrom > indexTo)
            //    throw new IndexOutOfRangeException();
            //return _models.GetRange(indexFrom, indexTo - indexFrom);
        }

        #endregion Private Methods
    }
}
