using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2v2
{
    public enum Frequency { Weekly, Monthly, Yearly };
    class Program
    {
        static void Main()
        {
           Person person = new Person();
            Console.WriteLine(person.ToFullString());

            Console.WriteLine();

            Article article = new Article();
            Console.Write(article.ToFullString());

            Console.WriteLine();

            Magazine magazine = new Magazine();
            Console.Write(magazine.ToString());



            Console.ReadLine();
        }
    }
}
