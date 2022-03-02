using System;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz: ";
            string degisken2 = "CSharp";

            /* Length */
            Console.WriteLine("******************** Length ********************");
            Console.WriteLine(degisken.Length);

            /* ToUpper, ToLower */
            Console.WriteLine("******************** toupper, tolower ********************");
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            /* Concat */
            Console.WriteLine("******************** Concat ********************");
            Console.WriteLine(String.Concat(degisken," Merhaba! "));

            
            /* Compare, CompareTo */
            Console.WriteLine("******************** Compare, Compareto ********************");
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            /* Contains */
            Console.WriteLine("******************** Contains ********************");
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            /* IndexOf */
            Console.WriteLine("******************** Indexof ********************");
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Burak"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            /* Insert */
            Console.WriteLine("******************** Insert ********************");
            Console.WriteLine(degisken.Insert(0,"Merhaba !"));

            /* Padleft, PadRight */
            Console.WriteLine("******************** Padleft, padright ********************");
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+ degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);
            
            /* Remove */
            Console.WriteLine("******************** remove ********************");
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            /* Replace */
            Console.WriteLine("******************** Replace ********************");
            Console.WriteLine(degisken.Replace("Csharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            /* Split */
            Console.WriteLine("******************** Split ********************");
            Console.WriteLine(degisken.Split(' ')[1]);

            /* Substring */
            Console.WriteLine("******************** Substring ********************");
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));



        }
    }
}
