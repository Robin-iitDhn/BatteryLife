using BackGroundTask.BackgroundTasks;
using System;
using System.Threading;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace BatteryChargedReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a console application, No User input is needed.");
            Thread.Sleep(1000);
            Console.WriteLine("Installing background process for battery notification.");
            BatteryNotifierTask.Register();
            Thread.Sleep(1000);
            Console.WriteLine("Background process complete.");
            Console.WriteLine("You are all Set!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
