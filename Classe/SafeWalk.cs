using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutomationStandalone
{
    class SafeWalk
    {
        public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOpt)
        {
            try
            {
                var dirFiles = Enumerable.Empty<string>();
                if (searchOpt == SearchOption.AllDirectories)
                {
                    dirFiles = Directory.GetDirectories(path)
                                        .SelectMany(x => EnumerateFiles(x, searchPattern, searchOpt));
                }
                return dirFiles.Concat(Directory.GetFiles(path, searchPattern));
            }
            catch (UnauthorizedAccessException ex)
            {
                return Enumerable.Empty<string>();
            }
        }
    }
}
