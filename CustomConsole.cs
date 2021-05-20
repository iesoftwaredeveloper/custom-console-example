using System.CommandLine;
using System.CommandLine.IO;

namespace custom_console_example
{
    public class CustomConsole : IConsole
    {
        public CustomConsole(IStandardStreamWriter stdOut = null, IStandardStreamWriter stdError = null)
        {

        }
        
        public IStandardStreamWriter Out => throw new System.NotImplementedException();

        public bool IsOutputRedirected => false;

        public IStandardStreamWriter Error => throw new System.NotImplementedException();

        public bool IsErrorRedirected => false;

        public bool IsInputRedirected => false;
    }
}