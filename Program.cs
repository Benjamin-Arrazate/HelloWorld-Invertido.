using System;

namespace ARRAY_BIDI_ESMIONAÑ
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "HelloWorld!";
            char[] charArray = texto.ToCharArray();
            Array.Reverse( charArray );
            Console.WriteLine(new string(charArray));
            
        }
    }
}
