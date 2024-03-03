class Program
{

    public class Solution
    {
        public static long Divide(long dividend, long divisor)
        {
            long result = 0;
            long signA,signB;
            signA=1;
            

            signB=1;
            if (dividend < 0 )
            {
                signA = -1;
                dividend=dividend*-1;

            }
            if (divisor < 0 )
            {
            signB= -1;
                divisor=divisor*-1;

            }
           
            while (dividend >= divisor)
            {
                dividend -= divisor;
                result ++;
            }
            return result * signA*signB;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solution.Divide(-2147483648,-1));
       }
    }
}