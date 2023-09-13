using System;

namespace SDKC2
{
    public class SDKC2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Flower>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var myClass = new Flower();

                Console.WriteLine("Enter the flower's name");
                myClass.Name = Console.ReadLine();

                Console.WriteLine("Enter the flower's color");
                myClass.Color = Console.ReadLine();

                recordList.Add(myClass);

                Console.WriteLine("You have added:");
                Console.WriteLine(myClass.Name);
                Console.WriteLine(myClass.Color);   
        }
        }
    }
}

