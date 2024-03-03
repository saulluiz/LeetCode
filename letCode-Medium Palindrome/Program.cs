using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

class Program
{

    static bool IsPalindrome(string y)
    {
        //bb
        for (int i = 0; i != y.Length; i++)
        {

            if (i > y.Length - i || y.Length==2 && y[0]==y[1]) return true;
            if (y[i] != y[y.Length - 1 - i]) return false;
        }



        return false;
    }
    static string LongestPalindrome(string s)
    {
        string varPal;
        string resolve="";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = s.Length - 1; j != i; j--)
            {
                if (s[i] == s[j])
                {
                    //manda string no intervalo i-j 
                    varPal = s.Substring(i, j - i + 1);
                    
                    


                    if (IsPalindrome(varPal))
                    {

                        if(resolve.Length<=varPal.Length){

                        resolve= varPal;
                        if(resolve.Length>=s.Length-i-1) return resolve;
                        }
                        

                    }
                }

            }

        }
        s=Convert.ToString(s[0]);
        if(resolve.Length<=s.Length){

        resolve= s;
        }
        return resolve;
    }
    static void Main(string[] args)
    {
       Console.WriteLine( LongestPalindrome(Console.ReadLine()));
    }
}