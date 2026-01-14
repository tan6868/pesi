
using System;
using System.Text;

namespace Ba_Tap_Tong
{
    class baiTapCsSharp {
        public static void Main() {
            int[] a = new int[100];
            int i, n, sum = 0;
            
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Tính tổng các phần tử có trong mảng C#:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Nhập số phần tử cần lưu vào mảng:");
            n = Convert.Tolnt32(Console.ReadLine());
            Console.WriteLine("Nhập {0} phần tử vào mảng:",n);

            for(i=0;i<n;i++){
                Console.WriteLine("Phần tử - {0}",i);
                a[i] = Convert.Tolnt32(Console.ReadLine());

            }
            for(i=0;i<n;i++)
            {
                sum += a[i]; 
            }
            Console.WriteLine("Tổng các phần tử trong mảng là:{0}",sum);
            Console.Readley();
        }
    }
}
