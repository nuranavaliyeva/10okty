#region task1
//namespace _10oktyabr12
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 3, 4, 0, 5 };
//            Console.WriteLine(GetMin(arr));
//        }
//        public static int GetMin(int[] arr)
//        {
//            int min = arr[0];
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] < min)
//                {
//                    min = arr[i];
//                }

//            }
//            return min;
//        }
//    }
//} 
#endregion




#region task2
namespace _10oktyabr12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sahe(5, 6);
            Sahe(7);
            Sahe(7, 8, 9);
            Sahe(1, 2, 3, 4, 5);
        }
        public static void Sahe(int a, int b)
        {
            Console.WriteLine("Duzbucaqlının sahesi: " + a * b);
        }
        public static void Sahe(decimal r, int p = 3)
        {
            Console.WriteLine("Çevrenin sahesi: " + p * r * r);
        }
        public static void Sahe(int a, int b, int c)
        {
            Console.WriteLine("Duzbucaqli paralelpipedin tam sethinin sahesi: " + 2 * (a * b + a * c + b * c));
        }
        public static void Sahe(int a, int b, int c, int p, int r)
        {
            p = (a + b + c) / 2;
            Console.WriteLine("Ucbucaqlinin daxiline çekilmis cevrenin sahesi: " + p * r);
        }
    }
}

#endregion
