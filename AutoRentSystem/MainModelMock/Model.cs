using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Make Make { get; set; }
        public int Seats { get; set; }
        public byte[] Photo { get; set; }
    }
}
