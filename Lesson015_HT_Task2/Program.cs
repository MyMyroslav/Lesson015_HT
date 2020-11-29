using System;

namespace Lesson015_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Train[] trains = new Train[2];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Enter number of {i} train:");
                trains[i].numberOfTrain = Console.ReadLine();
                Console.WriteLine($"Enter time of start of {i} train:");
                trains[i].timeOfStart = Console.ReadLine();
                Console.WriteLine($"Enter end point of {i} train:");
                trains[i].endPointName = Console.ReadLine();
                Console.WriteLine($"Number of train: {trains[i].numberOfTrain}, Time of Staring: {trains[i].timeOfStart}, End point name: {trains[i].endPointName}");
                Console.WriteLine(" ");
            }
            Console.WriteLine("Enter number of train you want to know about: ");
            string num2 = Console.ReadLine();
            for (int i = 0; i < 2; i++)
            {
                if (num2 == trains[i].numberOfTrain)
                {
                    Console.WriteLine($"Number of train: {trains[i].numberOfTrain}, Time of Staring: {trains[i].timeOfStart}, End point name: {trains[i].endPointName}");
                    return;
                }

                else
                {
                    Console.WriteLine("This number are not available");
                }
            }
        }

    }
}
