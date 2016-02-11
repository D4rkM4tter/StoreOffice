using System.Text;
using CommandLine;

namespace StoreOffice.Util
{
    class ArgumentOptions
    {
        [Option('?', "help", HelpText = "Print help.")]
        public bool Help { get; set; }

        [Option('i', "input", HelpText = "Input file to read.")]
        public string InputFile { get; set; }

        [Option('o', "output", DefaultValue = "output.xml", HelpText = "The name of the created Store Office xml file.")]
        public string OutputFile { get; set; }

        [Option('v', "verbose", HelpText = "Print details during execution.")]
        public bool Verbose { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            // this without using CommandLine.Text
            var usage = new StringBuilder();
            usage.AppendLine("ICA Online Store Office Xml generator utility version 0.2.");
            usage.AppendLine("");
            usage.AppendLine("-i => Input file (csv) that contains orginal data must be specified.");
            usage.AppendLine("-o => Output file could be specified. If not provided default output.xml will be used.");
            usage.AppendLine("");
            usage.AppendLine("-v => Verbose output.");
            usage.AppendLine("");
            usage.AppendLine("Exampel 1: --i data.csv");
            usage.AppendLine("");
            usage.AppendLine("Exampel 2: --i data.csv --o Rilles_store.xml");
            return usage.ToString();
        }
    }
}
