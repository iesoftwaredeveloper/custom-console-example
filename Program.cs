using System;
using System.CommandLine;
using System.CommandLine.IO;
using System.IO;

namespace custom_console_example
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            TextWriter tw = new StreamWriter(ms);

            IConsole console = new CustomConsole(StandardStreamWriter.Create(tw));

            var rootCommand = new RootCommand()
            {
                Description = "Console app to demonstrate System.CommandLine.IConsole"
            };

            Console.WriteLine("Hello World!");

            rootCommand.InvokeAsync(args, console).Wait();

            tw.Flush();
            ms.Position = 0;

            Console.Write(new StreamReader(ms).ReadToEnd());
        }
    }
}
