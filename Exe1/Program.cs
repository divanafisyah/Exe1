using System;
using System.Security.Cryptography.X509Certificates;

namespace BubbleSort
{
    class Program
    {
        //Deklarasi array int dengan ukuran 108
        private int[] diva = new int[108];
        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;
        //Fungsi / method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Add element of array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 108)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 108  elemen.\n");
                Console.WriteLine("");
                Console.WriteLine("---------------------");
                Console.WriteLine("Add element of array!");
                Console.WriteLine("---------------------");

                //User memasukkan elemen pada array
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("<" + (i + i) + ">");
                    string s1 = Console.ReadLine();
                    diva[i] = Int32.Parse(s1);
                }
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("Element array was sorted");
            Console.WriteLine("------------------------");
            for (int dn = n - 2; dn < n; dn++) ;
            {
                Console.WriteLine("");
            }
        }

        public void BubbleSortArray()
        {
            //For n - 1 passes
            for (int i = 1; i < n; i++)
            {
                //Pada pass dn, bandingkan n - i elemen pertama dengan elemen selanjutnya

                for (int dn = 0; dn < n - i; dn++)
                {
                    //Jika elemen tidak dalam urutan yang benar
                    if (diva[dn] < diva[dn + 1])
                    {
                        //Proses penukaran elemen
                        int temp;
                        temp = diva[dn];
                        diva[dn] = diva[dn + 1];
                        diva[dn + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Membuat objek pada kelas BubbleSort
            Program myList = new Program();
            //Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            //Pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            //Keluar
            Console.WriteLine("\n\nPress any key to exit!");
            Console.Read();


        }

    }
}