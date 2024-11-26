using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vdeo3
{
   class TruckLoad :Veheicle
    {
        public int Truclod {  get; set; } // trọng tải của xe 
        public TruckLoad():base()
        {
        }
        public TruckLoad(string id, string maker, string model, int year, double price,int truclod) : base(id, maker, model, year, price)
        {
             Truclod = truclod;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("TrucLoad :");
            Truclod =int.Parse( Console.ReadLine());

        }
        public override string Output()
        {
            return base.Output() + $" , TruckLoad : {Truclod}";   
        }
    }
}
