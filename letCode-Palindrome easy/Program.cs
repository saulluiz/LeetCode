class Program{

    static bool IsPalindrome(int x) {
        string y=Convert.ToString(x);
        for(int i=0;i!=y.Length;i++){
             Console.WriteLine(y[y.Length-1-i]+" "+y[i]) ;
            if(i>y.Length-i ) return true;
            Console.WriteLine("--");
            if(y[i]!=y[y.Length-1-i]) return false;
        }



        return false;
    }

static void Main(string[] args)
{
    Console.WriteLine(" Digite o Numero:");
    if(IsPalindrome(int.Parse(Console.ReadLine()))){
Console.WriteLine("É um palindromo");
    }
    else Console.WriteLine("Não é um palindromo");

}
}