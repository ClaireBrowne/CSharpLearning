using System;

namespace OneDimensionalArray
{
  class Program
  {
    static void Main(string[] args)
    {
            #region tong o vi tri chan
            //Console.WriteLine( "nhap so phan tu cua mang");
            //Console.WriteLine("--------------------------------------------");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[100];
            //int i = 0;
            //int tong = 0;
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("a[" + i + "]" + "=");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(" mang vua nhap la");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" {0}  ", a[i]);
            //}
            //Console.WriteLine();

            //for (i=0; i < n; i+=2 )
            //{
            //    tong = tong + a[i];
            //}
            //Console.Write("tong cac phan tu o vi tri chan la :");
            //Console.WriteLine(tong);
            #endregion
            #region chen mang 
            //Console.WriteLine(" nhap so pham tu mang a :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[100];
            //int i = 0;
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("a[" + i + "]" + "=");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(" mang vua nhap la");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" {0}  ", a[i]);
            //}
            //Console.WriteLine();
            //Console.Write("Nhap vi tri can chen: ");
            //int z = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write(" giá trị chen vao   ");
            //int k = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" mang moi la ");
            //for (i = 0; i < n; i++)
            //{
            //    for (i = 0; i < z; i++)
            //    {
            //        Console.WriteLine(a[i]);
            //    }
            //    for (i = z; i < n + 1; i++)
            //    {
            //        if (i == z)
            //        {
            //            a[i] = k;
            //            Console.WriteLine(a[i]);
            //        }
            //        if (i > z)
            //        {
            //            a[i] = a[i - 1];
            //            Console.WriteLine(a[i]);
            //        }
            //    }

            //}

            #endregion
            #region ghep mang
            //Console.WriteLine(" nhap so pham tu mang a :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[100];
            //int i = 0;
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("a[" + i + "]" + "=");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(" mang vua nhap la");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" {0}  ", a[i]);
            //}
            //Console.WriteLine();

            //Console.WriteLine(" nhap so pham tu mang b :");
            //int m = Convert.ToInt32(Console.ReadLine());
            //int[] b = new int[m];
            //for ( i = 0; i < m; i++)
            //{
            //    Console.Write("b[" + i + "]" + "=");
            //    b[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(" mang vua nhap la");
            //for (i = 0; i < m; i++)
            //{
            //    Console.Write(" {0}  ", b[i]);
            //}
            //int k = m + n;
            //int[] c = new int[k];
            //Console.WriteLine();
            //Console.Write(" mang ghep la ");
            //for ( i = 0; i < n; i++)
            //{
            //    c[i] = a[i];
            //    Console.Write("   " + c[i]);
            //}
            //for (i = 0; i < m; i++)
            //{
            //    c[n] = b[i];
            //    Console.Write("   " + c[n]);
            //}
            #endregion
            #region mang am mang duong
            //Console.WriteLine(" nhap so pham tu mang a :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[100];
            //int i = 0;
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("a[" + i + "]" + "=");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(" mang vua nhap la");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" {0}  ", a[i]);
            //}
            //Console.WriteLine();
            //Console.Write("mang duong la");
            //for ( i = 0; i < n; i++)
            //{
            //    if (a[i] >= 0)
            //    { Console.Write("  " + a[i]); }
            //}
            //Console.WriteLine();
            //Console.Write("mang am la");
            //for ( i = 0; i < n; i++)
            //{
            //    if (a[i] < 0)
            //    { Console.Write("  " + a[i]); }
            //}
            #endregion
            #region mang chua cac phan tu duy nhat
            //Console.WriteLine(" nhap so pham tu mang a :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[100];
            //int i = 0;
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("a[" + i + "]" + "=");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(" mang vua nhap la");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" {0}  ", a[i]);
            //}

            //Console.WriteLine();
            //Console.Write(" mang co phan tu duy nhat :");
            //for (i = 0; i < n; i++)
            //{
            //    int count = 0;
            //    for (int j = i + 1; j < n - 1; j++)
            //    {
            //        if (a[i] == a[j])
            //        {
            //            count++;
            //        }
            //    }
            //    for (int k = i - 1; k >= 0; k--)
            //    {
            //        if (a[i] == a[k])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 0)
            //    {
            //        Console.Write("  " + a[i]);
            //    }
            //}
            #endregion
            #region mang dao nguoc , tong , mang sao chep
            //Console.WriteLine(" nhap so pham tu mang a :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[100];
            //int i = 0;
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("a[" + i + "]" + "=");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(" mang vua nhap la");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" {0}  ", a[i]);
            //}
            //Console.WriteLine();
            //Console.Write(" mang  dao nguoc  la");

            //for (i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(" {0}  ", a[i]);
            //}

            //Console.WriteLine();
            //Console.WriteLine(" tong la ");
            //int tong = 0;
            //for ( i = 0; i < n; i++)
            //{
            //    tong = tong + a[i];
            //}
            //Console.WriteLine(tong);

            //Console.WriteLine();
            //Console.WriteLine("mang sao chep la :");
            //int[] a1 = new int[n];
            //for ( i = 0; i < n; i++)
            //{
            //    a1[i] = a[i];
            //    Console.Write(" {0}   ", a[i]);

            //}
            #endregion
            #region lon nhat be nhat
            //Console.WriteLine(" nhap so pham tu mang a :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[100];
            //int i = 0;
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("a[" + i + "]" + "=");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(" mang vua nhap la");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" {0}  ", a[i]);
            //}
            //Console.WriteLine();
            //int max = a[0];
            //int min = a[0];
            //for (i = 1; i < n ; i++)
            //{

            //    if (max <= a[i])
            //    {
            //        max = a[i];
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine(" so lon nhat la : {0}", max);
            //for (i = 1; i < n; i++)
            //{

            //    if (min >= a[i])
            //    {
            //        min = a[i];
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(" so nho nhat la : {0}", min);
            #endregion
        }
    }
}
