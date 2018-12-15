using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> myStringList = new List<string>();

            myStringList.Add("C#");
            myStringList.Add("java");
            myStringList.Add("javascript");
            myStringList.Add("python");


            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");

            if(myStringList.Contains("java"))
            {
                myStringList.Remove("java");
            }

            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");

            Zoo zoo = new Zoo();
            
            foreach (var animal in zoo.Animals)
            {
                Console.WriteLine($"This is a {animal.Name}, and it is a {animal.Gender}");
            }

            Console.WriteLine("_____________stack");

            Stack<string> myStack = new Stack<string>();
            myStack.Push("C#");
            myStack.Push(".Net");
            myStack.Push("SQL");

            //foreach(var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            int count = myStack.Count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myStack.Pop());

            }

            Console.WriteLine("_____________queue coada");

            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("C#");
            myQueue.Enqueue(".Net");
            myQueue.Enqueue("SQL");

            int countQ = myQueue.Count;

            for (int i = 0; i < countQ; i++)
            {
                Console.WriteLine(myQueue.Dequeue());

            }

            Console.WriteLine("_____________dictionary");

            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
            dict.Add("Gigi", 30.23m);
            dict.Add("Ion", 25.30m);
            dict.Add("Ramona", 300.99m);

            foreach(var record in dict)
            {
                Console.WriteLine($"{record.Key} : {record.Value}");
            }


            Dictionary<string, List<string>> keyListDictionary = new Dictionary<string, List<string>>();

            List<ILandBound> landAnimals = new List<ILandBound>();




        }
    }
}
