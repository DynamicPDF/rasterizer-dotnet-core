using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace rasterizer_dotnet_core
{
    class Util
    {
        // This is a helper function to get a full path to a file in the Resources folder.
        internal static string GetResourcePath(string inputFileName)
        {
            var exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return System.IO.Path.Combine(appRoot, "Resources", inputFileName);
        }
    }
}
