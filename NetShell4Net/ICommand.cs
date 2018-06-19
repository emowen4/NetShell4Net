using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Monicais.NetShell4Net
{
    public interface ICommand
    {

        string Name { get; }

        ICommand Parent { get; }

        bool Execute(string command, out string outputs);
    }
}
