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
                Console.WriteLine("4. Ma tran tu linh");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon: ");

                // Tranh nhap crash khi sai
                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Nhap sai! Vui long nhap so (1-5).");
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
                        int[,] maTran = new int[3, 3];
                        Random rd = new Random();
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                maTran[i, j] = rd.Next(1, 101);
                            }
                        }

                        Console.WriteLine("\nMa tran linh khi:");
                        
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write(maTran[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        
                        int max = maTran[0, 0];
                        int hang = 0, cot = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (maTran[i, j] > max)
                                {
                                    max = maTran[i, j];
                                    hang = i;
                                    cot = j;
                                }
                            }
                        }

                        Console.WriteLine($"Max = {max} tai vi tri [{hang},{cot}]");
                        break;
                    case 5:
                        return;
                     default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
} 