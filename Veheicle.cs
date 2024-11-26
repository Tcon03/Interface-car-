using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vdeo3
{
    class Veheicle : IVehicle
    {
     

        public string Id {  get; set; } // mã định danh xe 
        public string Maker { get; set; } // Nhà sản xuất 

        public string Model { get; set; } // mẫu xe 
        public int Year {  get; set; }  // năm sản xuất 
        public double Price {  get; set; } //Giá

        public Veheicle()
        {
        }
        public  Veheicle(string id , string maker , string model , int year , double price)
        {
            Id = id;
            Maker = maker;
            Model = model;  
            Year = year;
            Price = price;

        }
        public Veheicle( string id )
        {
            Id= id;
        }
        public virtual void Input()
        {
            Console.Write("Id : ");
            Id = Console.ReadLine();
            Console.Write("Maker : ");
            Maker = Console.ReadLine();
            Console.Write("Model : "); 
            Model = Console.ReadLine();
            Console.Write("Year  : "); 
            Year = int.Parse(Console.ReadLine());
            Console.Write("Price : "); 
            Price = double.Parse(Console.ReadLine());
        }


        public virtual string Output() 
        {
            return string.Format("Id: {0}, Maker: {1}, Model: {2}, Year: {3}, Price: {4:F3}",
                         Id, Maker, Model, Year, Price);

        }
       
    }
}
