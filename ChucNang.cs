using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vdeo3
{
    class ChucNang
    {
        List<Veheicle> Them = new List<Veheicle>();
        public void AddCar()
        {
            //Car c1 = new Car();
            //c1.Input();
            //Console.WriteLine("========================");
            //c1.Output();
            //Them.Add(c1);
            //Console.WriteLine("========================");
            //TruckLoad T1 = new TruckLoad();
            //T1.Input();
            //T1.Output();
            //Them.Add(T1);

            Them.Add(new Car("1", "billgate", "Rangrover", 2012, 90000, "black"));
            Them.Add(new Car("2", "Truong", "For", 2015, 50000, "blue"));
            Them.Add(new Car("3", "jackma", "cx5", 2016, 70000, "white"));

            // id     nhà sxua   hang       nam   giá    tải trọng 
            Them.Add(new TruckLoad("4", "Truong", "Mecedes", 2014, 80000, 5));
            Them.Add(new TruckLoad("5", "Truong", "huynhdai", 2019, 60000, 4));
            Them.Add(new TruckLoad("6", "Cuong", "Honda", 2012, 70000, 6));

            Console.WriteLine("\nAdd Car Success !!");

        }
        public void DisPlay()
        {
            foreach (var item in Them)
            {
                Console.WriteLine(item.Output());

            }
        }
        public void SearchId()
        {
            Console.Write("ID : ");
            string id = Console.ReadLine();
            var search = Them.Find(x => x.Id == id);
            if (search != null)
            {
                var iteam = search.Output();
                Console.WriteLine(iteam);
            }
            else
            {
                Console.WriteLine("Vui long nhap dung id !!!");
            }

        }
        public void SearchMarker()
        {
            Console.WriteLine("Search Maker : ");
            string search = Console.ReadLine();
            var timkiem = Them.Find(x => x.Maker.ToLower() == search.ToLower());
            if (timkiem != null)
            {
                var item = timkiem.Output();
                Console.WriteLine(item);

            }
            else
            {
                Console.WriteLine("Vui lòng nhập đúng maker cần tìm kiếm !!!");
            }
        }
        public void SapSep()
        {

            try
            {
                var xep = Them.OrderBy(X => X.Price).ToList();
                Console.WriteLine("Danh sách sau khi được sắp xếp  theo giá tăng dần");
                foreach (var item in xep)
                {

                    Console.WriteLine(item.Output());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void SapxepYear()
        {
            var tim = Them.OrderBy(x => x.Year).ToList();
            Console.WriteLine("Nam san xuat sau khi duoc sap xep la :");
            foreach (var item in tim)
            {
                Console.WriteLine(item.Output());
            }
        }
        public void GhiFile(string path)
        {
            try
            {


                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var sv in Them)
                    {
                        sw.WriteLine(sv.Output());

                    }
                    Console.WriteLine("Ghi file thành công vào trong tệp ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DocFile(string path)
        {
            //if (File.Exists(path))
            //{
            try
            {

                if (File.Exists(path))
                {
                    if (path != null)
                    {



                        using (StreamReader sr = new StreamReader(path))
                        {
                            string doc = sr.ReadToEnd();
                            Console.WriteLine("Noi dung trong tep là : \n" + doc);
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            {

            }
            //}
            //else
            //{
            //    Console.WriteLine("File không tồn tại vui lòng thêm nội dung vào file nh");
            //}

        }
        public void XoaNoiDung(string file) // xóa nội dung trong tệp 
        {
            try
            {


                using (StreamWriter sr = new StreamWriter(file))
                {
                    // không ghi gì vào tệp gọi là xóa file rỗng 
                }
                Console.WriteLine($"Nội dung trong đường dẫn {file} đã bị xóa !!! ");
            }catch(Exception ex)
            {
                Console.WriteLine("Lỗi thực hiện xóa file nội dung  "+ex.Message);
            }
        }
    }
}
