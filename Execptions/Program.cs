using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execptions
{
    class Program
    {

        static void Main(string[] args)
        {
            //try
            //{
            //    int a, b;
            //    a = 2;
            //    b = 0;
            //Test test = new T

            //Test.Name;
            var name = ConfigurationManager.AppSettings["name"];
            Console.WriteLine(name);
                //Names names = Names.Krzysiek;
                //switch (names)
                //{
                //    case Names.Roman:
                //        break;
                //    case Names.Anna:
                //        break;
                //    case Names.Krzysiek:
                //        Console.WriteLine(Names.Krzysiek.ToString());
                //        Console.WriteLine((int)Names.Krzysiek);
                //        break;
                //    default:
                //        break;
                //}
            //    throw new Exception("testowy blad");
            //    int x = a / b;
            //}
            //catch (DivideByZeroException zero)
            //{
            //    Console.WriteLine(zero.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message); 
            //}
            //finally
            //{
            //    Console.WriteLine("koniec");
            //}
            Console.Read();
        }
    }
}
