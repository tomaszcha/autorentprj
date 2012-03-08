using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class Auto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Insuarance Insuarance { get; set; }
        public Model Model { get; set; }
        public Category Category { get; set; }
        public short Year { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public DateTime LastCheckDate { get; set; }
        public string Description { get; set; }
    }
}
