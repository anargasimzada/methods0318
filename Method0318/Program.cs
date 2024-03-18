namespace Method0318
{
    internal class Program
    {
        static void Main(string[] args)
        //{
        //    int[] arr = { 5, 12, 54, 37, 7 };
        //    Min(arr);
        //}
        //public static int Min(int[] nums)
        //{
        //    int[] enK = { 5, 12, 54, 37, 7 };
        //    int hide =enK[0];
        //    for(int i=0; i <enK.Length; i++)
        //    {
        //        if (enK[i]<hide)
        //        {
        //            hide=enK[i];
        //            return i;
        //        }
        //    }Console.WriteLine(hide);
        //    return 0;
        //}

//            Area deyə Method(lar) yaradılır.
//1. Çevrənin sahəsi - S = p* r² (p=3)
//2. Düzbucaqlının sahəsi - S = a* b
//3. Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a* b+a* c+b* c)
//4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p* r; p=(a+b+c)/2

        {
            Console.WriteLine(Area(2,3,1,2)); 
        }

        public static int Area(int r)
        {
            int p = 3;
            return p*r*r;

        }
        public static int Area(int a, int b)
        {
           return a*b;
        }

        public static int Area(int a, int b, int c)
        {
            return 2*(a * b +a* c+b*c);
        }
        public static int Area( int r, int a, int b,int c)
        {
            return ((a + b + c) / 2) * r;
        }
    }
}
