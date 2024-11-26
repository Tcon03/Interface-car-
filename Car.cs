using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vdeo3
{
    class Car : Veheicle
    {
        public string Color { get; set; }
        public Car() : base()
        {

        }
        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            Color = color;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Color :");
            Color = Console.ReadLine();
        }
        public override string Output()
        {
           return base.Output() +$" , Color : {Color}";
            
        }
    }
}
