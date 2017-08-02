using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLFSAtrsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string attrsPath = Path.Combine(currentDirectory, ".gitattributes");

            // Check if that is unity project.
            if(!File.Exists(attrsPath))
            {
                Console.WriteLine(".gitattributes not found! Is .exe inside root of your project?");
                Console.ReadKey();
                return;
            }

            var lines = File.ReadAllLines(attrsPath);
            bool started = false;

            foreach (var line in lines)
            {
                if (started)
                {
                    LaunchLFS(line);
                }

                if (line.Equals("#LFS"))
                {
                    started = true;
                }
            }

            if(!started)
            {
                Console.WriteLine("#LFS line not found in .gitattributes. Nothing to do over here.");
            }
            else
            {
                Console.WriteLine("Okay, we finished! :)");
            }
           
            Console.ReadKey();
        }

        private static void LaunchLFS(string line)
        {
            var splitted = line.Split(' ');

            // *.tga filter=lfs diff=lfs merge=lfs -text ==> 5
            if (splitted.Length != 5)
            {
                Console.WriteLine("Line has wrong format => " + line);
                return;
            }

            Console.WriteLine("*Processing => " + splitted[0]);

            string command = string.Format("/C git lfs track {0} --no-modify-attrs", splitted[0]);

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();

            process.WaitForExit();

            Console.WriteLine("*Done!");
            Console.WriteLine("============================");
        }
    }
}
