using System;
using System.Net;
using System.IO;
using System.IO.Compression;
namespace Invit14_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Project Invit14 Downloader";
            System.Console.WriteLine("Created By AlainsXisaDuck");
            System.Console.WriteLine("Downloading.....");

            string dir = @"C:\Invit14";
            // AlainsX, dont forget this is where you fucking create a folder
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://www.retblox.tk/Download/Player.zip", @"C:\Invit14\Player.zip");
            ZipFile.ExtractToDirectory(@"C:\Invit14\Player.zip", @"C:\Invit14\");
            System.Console.WriteLine("Complete! Now go to C:, Invit14, Player to Host, Join!");

        }
    }
}
