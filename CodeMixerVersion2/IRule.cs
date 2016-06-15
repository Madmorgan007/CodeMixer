using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMixerVersion2
{
    public interface IRule
    {
        void Process(string text);
    }
}
