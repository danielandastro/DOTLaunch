using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace DOTLaunch
{
    class Program
    {
        static Dictionary<string, string> progList = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            var launchFolderPath = ""; //Variable for folder path
            var ver = "0.1";//Version
            Console.WriteLine("Welcome to DotLaunch"+ver);
            Console.Write("Please provide path to launcher folder: ");
            launchFolderPath = Console.ReadLine();//Reads launch folder path
            var progListPath = launchFolderPath + "/launch.list";
            if (!File.Exists(progListPath))
            {
                Console.WriteLine("Launch folder is invalid or program list is missing(launch.list)");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            var list = File.ReadAllLines(progListPath);
            foreach (var line in list)
            {
                if (line.Contains("//")){}
                else
                {
                    var split = line.Split(':');
                    progList.Add(split[0], launchFolderPath+"/"+split[1]);
                }
            }

            while (true)
            {
                Console.Write("Please enter program name: ");
                var progname = Console.ReadLine();
                if(progname.Equals("exit")) {clearCache(); return;}
                Execute(progname);
                
            }

            {
                
            }
        }

        static void Execute(string name)
        {
            var path = "";
            if (progList.TryGetValue(name, out path))
            {
                #if DEBUG
                Console.WriteLine("csc "+path+"/DotLaunch.run");
                #endif
                if (!File.Exists(path + "/DotLaunch.exe"))
                {
                    var process = Process.Start("mcs",path + "/DotLaunch.run");
                    process.WaitForExit();
                }
                
                var processMono = Process.Start("mono", path+"/DotLaunch.exe");
                processMono.WaitForExit();
                //

            }
            else
            {
                Console.WriteLine("Program not in list");
            }
            
        }

        static void clearCache()
        {
            foreach (var value in progList)
            {
                if(File.Exists(value.Value+"/DotLaunch.exe"))
                {
                    File.Delete(value.Value+"/DotLaunch.exe");
                }
            }
        }
    }
}