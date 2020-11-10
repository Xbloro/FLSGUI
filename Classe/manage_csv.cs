using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutomationStandalone
{
    class manage_csv
    {
        
        public manage_csv()
        {
            ;
        }

        string FormatLineToCSV(List<string> tabStr)
        {
            string line = "";
            foreach (var st in tabStr)
            {
                try
                {
                    if (st == tabStr.Last())
                    {
                        line = line + st;
                    }
                    else
                    {
                        line = line + st + ",";
                    }
                }
                catch(Exception ex) {Console.WriteLine(ex);}
            }
            return line;
        }
        
        public void WriteLineToCsv(string pathToCSV, List<string> tabLine)
        {
            using (var w = new StreamWriter(pathToCSV, true))
            {
                try
                {
                    var formatedLine = FormatLineToCSV(tabLine);
                    w.WriteLine(formatedLine);
                    w.Flush();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        
    }
}
