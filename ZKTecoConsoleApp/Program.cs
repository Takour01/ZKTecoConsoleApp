using PullSDK_core;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the device connection class
        AccessPanel device = new AccessPanel();

        // Connect to the device using its IP, port, and password (if any)
        if (!device.Connect("192.168.1.201", 4370, 123456, 5000))
        {
            Console.WriteLine("Failed to connect to the device.");
            return;
        }

        // Read users from the device
        List<User> users = device.ReadUsers();
        if (users == null)
        {
            Console.WriteLine("Failed to read users.");
            return;
        }

        // Example: Open door 1 for 5 seconds
        if (!device.OpenDoor(1, 5))
        {
            Console.WriteLine("Failed to open the door.");
            return;
        }

        Console.WriteLine("Operation completed successfully.");
    }
}
