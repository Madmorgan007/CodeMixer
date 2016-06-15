using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMixerVersion2
{
    public static class Extensions
    {
        public static string Clean(this string str)
        {
            return str.Replace("=", string.Empty).Replace("+", string.Empty).Replace("\\", string.Empty).Replace("/", string.Empty);
        }
    }
}
