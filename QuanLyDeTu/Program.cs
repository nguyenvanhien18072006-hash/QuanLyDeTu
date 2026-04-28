// Phan 1
// Khoi tao du an QuanLyDeTu
 using System;

namespace QuanLyDeTu
{
    class Program
    {
        static void Main()
        {
            DeTu[] danhSach = new DeTu[100];
            int soLuong = 0;
            int chon;

            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Them de tu");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Tim de tu xuat sac");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon: ");

                // Tranh nhap crash khi sai
                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Nhap sai! Vui long nhap so (1-4).");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        // kiem tra day mang 
                        if (soLuong < 100)
                        {
                            danhSach[soLuong] = new DeTu();
                            danhSach[soLuong].NhapThongTin();
                            soLuong++;
                        }
                        else
                        {
                            Console.WriteLine("Danh sach da day!");
                        }
                        break;

                    case 2:
                        if (soLuong == 0)
                        {
                            Console.WriteLine("Danh sach rong!");
                        }
                        else
                        {
                            for (int i = 0; i < soLuong; i++)
                            {
                                danhSach[i].HienThi();
                            }
                        }
                        break;

                    case 3:
                        // kiem tra co de tu xuat sac khong 
                        bool timThay = false;

                        for (int i = 0; i < soLuong; i++)
                        {
                            if (danhSach[i].TinhDiemTong() > 25)
                            {
                                danhSach[i].HienThi();
                                timThay = true;
                            }
                        }

                        if (!timThay)
                        {
                            Console.WriteLine("Khong co de tu xuat sac!");
                        }
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
} 