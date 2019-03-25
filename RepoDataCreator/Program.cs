using System;
using downloaderLibrary;
using repoBaseLib;
using System.Collections.Generic;
namespace RepoDataCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<DataPacket>();
            var dataToAdd = new DataPacket();
            Console.WriteLine("Add data");
            Console.WriteLine("Enter Name: ");
            dataToAdd.name = Console.ReadLine();
            Console.WriteLine("Enter Description: ");
            dataToAdd.description = Console.ReadLine();
            Console.WriteLine("Enter Launch String: ");
            dataToAdd.launchString = Console.ReadLine();
            Console.WriteLine("Enter version: ");
            dataToAdd.version = Console.ReadLine();
            Console.WriteLine("Enter Candidate Name: ");
            dataToAdd.versionCandidateName = Console.ReadLine();
            Console.WriteLine("Enter Repository URL: ");
            dataToAdd.repoURL = Console.ReadLine();
            Console.WriteLine("Enter File URL: ");
            dataToAdd.fileURL = Console.ReadLine();
            dataToAdd.releaseDate = DateTime.Now;
            Console.WriteLine("________");
            data.Add(dataToAdd);


            Console.WriteLine("Second Entry");
            Console.WriteLine("Add data");
            Console.WriteLine("Enter Name: ");
            dataToAdd.name = Console.ReadLine();
            Console.WriteLine("Enter Description: ");
            dataToAdd.description = Console.ReadLine();
            Console.WriteLine("Enter Launch String: ");
            dataToAdd.launchString = Console.ReadLine();
            Console.WriteLine("Enter version: ");
            dataToAdd.version = Console.ReadLine();
            Console.WriteLine("Enter Candidate Name: ");
            dataToAdd.versionCandidateName = Console.ReadLine();
            Console.WriteLine("Enter Repository URL: ");
            dataToAdd.repoURL = Console.ReadLine();
            Console.WriteLine("Enter File URL: ");
            dataToAdd.fileURL = Console.ReadLine();
            dataToAdd.releaseDate = DateTime.Now;
            Console.WriteLine("________");
            data.Add(dataToAdd);

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(data));

        }
    }
}
