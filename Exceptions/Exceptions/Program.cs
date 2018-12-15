using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //    try
            //    {
            //        int b = 100;
            //        int a = b / 0;
            //        Console.WriteLine(a);
            //    }
            //     catch (DivideByZeroException exception) //declar in blocul catch o noua variabila exception
            //    {
            //        Console.WriteLine("Ups, something happened!");
            //        Console.WriteLine(exception.Message);
            //        Console.WriteLine(exception.StackTrace);
            //    }


            try
            {
                Person person = new Person(15);
                Person per1 = new Person(-2);
                Person per3 = new Person(2);
                Person per2 = new Person(81);

            }
            catch (ArgumentException e)
            {
                //this will show all the errors:
                //cw(e);
                Console.WriteLine(e.Message + e.GetType());
                //throw;
            }
            catch (DressCodeException a)
            {
                Console.WriteLine(a.Message + a.GetType());
            }
            //sau putem pune doar Exception e, si cuprinde toate exceptiile
          
        }
    }
}
