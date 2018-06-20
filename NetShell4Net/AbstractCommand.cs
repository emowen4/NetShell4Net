using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Monicais.NetShell4Net
{
    public abstract class AbstractCommand : ICommand
    {
        protected AbstractCommand(string name, ICommand parent)
        {
            Name = name;
            Parent = parent;
        }

        public string Name { get; }

        public ICommand Parent { get; }

        public virtual bool Execute(string command, out string outputs)
        {
            if (Parent != null)
            {
                return Parent.Execute(string.Concat(Name, " ", command), out outputs);
            }
            else
            {
                var info = new ProcessStartInfo
                           {
                               Arguments = command,
                               CreateNoWindow = true,
                               ErrorDialog = false,
                               FileName = "cmd.exe",
                               RedirectStandardOutput = true,
                               StandardOutputEncoding = Encoding.Unicode,
                               UseShellExecute = false
                           };
                var process = Process.Start(info);
                if (process == null)
                {
                    outputs = string.Empty;
                    return false;
                }
                var outputReader = process.StandardOutput;
                process.WaitForExit();
                outputs = outputReader.ReadToEnd();
#if TEST
                outputs = $"{command}\n{outputs}";
#endif
                outputReader.Close();
                return process.ExitCode == 0;
            }
        }

        public bool Dump(out string outputs)
        {
            return Execute("dump",
                           out outputs);
        }

        public bool Help(out string outputs)
        {
            return Execute("help",
                           out outputs);
        }
    }
}
