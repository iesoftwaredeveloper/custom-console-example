using System;
using System.CommandLine;
using System.CommandLine.IO;

namespace custom_console_example
{
    public class CustomConsole : IConsole
    {
        public CustomConsole(IStandardStreamWriter stdOut = null, IStandardStreamWriter stdError = null)
        {
            if (stdOut != null)
            {
                Out = stdOut;
            }
            else
            {
                Out = StandardStreamWriter.Create(Console.Out);
            }

            if (stdError != null)
            {
                Error = stdError;
            }
            else
            {
                Error = StandardStreamWriter.Create(Console.Error);
            }
        }

        public IStandardStreamWriter Out { get; }

        public bool IsOutputRedirected => false;

        public IStandardStreamWriter Error { get; }

        public bool IsErrorRedirected => false;

        public bool IsInputRedirected => false;
    }
}