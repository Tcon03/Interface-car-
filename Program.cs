using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vdeo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int chocie;
            ChucNang option = new ChucNang();
            do
            {

                Console.WriteLine("========================");
                Console.WriteLine("1. Nhập dữ liệu");
                Console.WriteLine("2. Hiển thị dữ liệu");
                Console.WriteLine("3. Tìm kiếm theo id");
                Console.WriteLine("4. Tìm kiếm theo maker");
                Console.WriteLine("5. Sắp xếp theo price");
                Console.WriteLine("6. Sắp xếp theo năm sản xuất");
                Console.WriteLine("7. Ghi File");
                Console.WriteLine("8. Đọc File");
                Console.WriteLine("9. Xóa File  ");
                Console.Write("*** Choice: ");
                string path = @"data.txt";
                if (int.TryParse(Console.ReadLine(), out chocie))
                {
                    switch (chocie)
                    {
                        case 1:
                            option.AddCar();
                            break;
                        case 2:
                            option.DisPlay();
                            break;
                        case 3:
                            option.SearchId();
                            break;
                        case 4:
                            option.SearchMarker();
                            break;

                        case 5:
                            option.SapSep();
                            break;

                        case 6:
                            option.SapxepYear();
                            break;
                        case 7:
                            option.GhiFile(path); 
                            break;
                        case 8:
                            option.DocFile(path);
                            break;
                        case 9:
                            option.XoaNoiDung(path); 
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập đúng chức năng ");
                }

            }
            while (chocie != 10);
        }
    }
}
