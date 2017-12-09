using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Namespaces.Person person = new Namespaces.Person("Dias", "Urinbasarov", "Kazakh", 17, 180, 70);
            Console.WriteLine(Namespaces.Method.GetParametres(person));

            //2
            Console.WriteLine("\nЧисловая константа:{0}\nСтроковая константа: {1}", Namespaces.Const.Digits, Namespaces.Const.Akademy);
           
            Console.ReadLine();
       
        }

        
    }
}
