using System;
using System.IO;
namespace FileManagement
{
    class Manage
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\avita\OneDrive\Desktop\PROJECT C# .NET\MyFile.txt";
            // File.WriteAllText(filepath,$"Line 1{Environment.NewLine}Line 2");
            Console.WriteLine(File.ReadAllText(filepath));
            string[]lines = File.ReadAllLines(filepath);
            Console.WriteLine(lines[0]);
        }
    }
}
