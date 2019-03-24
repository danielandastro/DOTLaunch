using System;

namespace Repoextractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var doofus = new downloaderLibrary.DataHandler();
            string hi = doofus.Presenter(doofus.Extractor(Console.ReadLine()));
            Console.WriteLine(hi);
        }
    }
}
