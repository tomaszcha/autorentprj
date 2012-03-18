using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelMock;

namespace TestProtocol
{
    public class CompareMathods
    {
        public static bool Compare(Model model1, Model model2)
        {
            bool res = true;
            if (model1 == null)
            {
                if (model2 != null)
                    res = false;
            }
            else
                if (model2 == null)
                {
                    if (model1 != null)
                        res = false;
                }
            {
                if (!Compare(model1.Category, model2.Category))
                    res = false;
                else
                    if (model1.DayRate != model2.DayRate)
                        res = false;
                    else
                        if (model1.Deposit != model2.Deposit)
                            res = false;
                        else
                            if (model1.EngineCapacity != model2.EngineCapacity)
                                res = false;
                            else
                                if (model1.Id != model2.Id)
                                    res = false;
                                else
                                    if (model1.KmRate != model2.KmRate)
                                        res = false;
                                    else
                                        if (model1.Name != model2.Name)
                                            res = false;
                                        else
                                            if (model1.Seats != model2.Seats)
                                                res = false;
                                            else
                                            {
                                                if (model1.Photo!= null & model2.Photo!=null) 
                                                {
                                                    if (model1.Photo.Length != model2.Photo.Length)
                                                        res = false;
                                                    else
                                                        for (int i = 0; i < model1.Photo.Length; i++ )
                                                        {
                                                            if (model1.Photo[i] != model2.Photo[i])
                                                            {
                                                                res = false;
                                                                break;
                                                            }
                                                        }
                                                }
                                                else
                                                {
                                                    if (!(model1.Photo!=null & model2.Photo!=null))
                                                        res = false;
                                                }
                                            }
            }
            return res;
        }

        public static bool Compare(Category category1, Category category2)
        {
            bool res = true;
            if (category1 == null)
            {
                if (category2 != null)
                    res = false;
            }
            else
                if (category2 == null)
                {
                    if (category1 != null)
                    {
                        res = false;
                    }
                }
                else
                {
                    if (category1.Id != category2.Id)
                        res = false;
                    else
                        if (category1.Name != category2.Name)
                            res = false;
                        else
                            if (category1.Deposit != category2.Deposit)
                                res = false;
                }
            return res;
        }

        public static bool Compare(Make make1, Make make2)
        {
            bool res = true;
            if (make1 == null)
            {
                if (make2 != null)
                    res = false;
            }
            else
                if (make2 == null)
                {
                    if (make1 != null)
                        res = false;
                }
                else
                {
                    if (make1.Id != make2.Id)
                        res = false;
                    else
                        if (make1.Name != make2.Name)
                            res = false;
                }
            return res;
        }

        public static bool Compare<T>(List<T> list1, List<T> list2) where T: Model//, Make , Category
        {
           bool res = true;
            if (list1 == null)
            {
                if (list2 != null)
                    res = false;
            }
            else
                if (list2 == null)
                {
                    if (list1 != null)
                        res = false;
                }
                else
                {
                    if (list1.Count != list2.Count)
                        res = false;
                    else
                    {
                        for (int i = 0; i < list1.Count; i++)
                        {
                            if (!Compare(list1[i], list2[i]))
                            {
                                res = false;
                                break;
                            }
                        }
                    }
                }
            return res;
        }
    }
}
