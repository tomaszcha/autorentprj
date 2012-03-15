﻿using System.Collections.Generic;
using ModelMock;

namespace DBMock
{
    public class Models
    {
        public List<Model> List;
        public Models()
        {
            List = new List<Model>()
                                     {
                                         new Model
                                             {
                                                 Id = 1,
                                                 Make = new Make() {Id = 1, Name = "Mazda"},
                                                 Name = "CX-5",
                                                 EngineCapacity = "2",
                                                 Seats = 5,
                                                 DayRate = 700,
                                                 HourRate = 300,
                                                 Deposit = 0
                                             },
                                         new Model
                                             {
                                                 Id = 2,
                                                 Make = new Make() {Id = 1, Name = "Opel"},
                                                 Name = "Antara",
                                                 EngineCapacity = "2.2",
                                                 Seats = 5,
                                                 DayRate = 900,
                                                 HourRate = 400,
                                                 Deposit = 0
                                             },
                                         new Model
                                             {
                                                 Id = 3,
                                                 Make = new Make() {Id = 1, Name = "Lexus"},
                                                 Name = "Es",
                                                 EngineCapacity = "2",
                                                 Seats = 5,
                                                 DayRate = 1100,
                                                 HourRate = 500,
                                                 Deposit = 1100
                                             }

                                     };
        }
    }
}
