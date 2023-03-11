using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Car
    {
        public string Mark, Model, Color, Number;

        public Car(string mark = "No mark", string model = "No model", string color = "No color", string number = "No number")
        {
            this.Mark = mark;
            this.Model = model;
            this.Color = color;
            this.Number = number;
        }
    }
}
