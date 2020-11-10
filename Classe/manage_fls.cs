using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AutomationStandalone
{
    class manage_fls
    {
        
        string m_pathToCSV;
        string m_machineName = Environment.MachineName;
        string m_csv = "fls.csv";
        string m_mainPath;
      

        public manage_fls(string mainPath)
        {
          m_mainPath = mainPath;
          m_pathToCSV = Path.Combine(mainPath, m_csv);
        }

        public void GenerateCSVFls(string path)
        {
            var l_pathToCSV = Path.Combine(path, m_csv);
            List<string> header = new List<string> {"file","lastAccessedTime","creationTime","LastWritedTime"};
            manage_csv csv = new manage_csv();
            csv.WriteLineToCsv(l_pathToCSV,header);
        }

        public void GetFLS(string path)
        {
            try
            {
                manage_csv csv1 = new manage_csv();
                
                foreach (string file in SafeWalk.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
                {
                    List<string> lStr = new List<string>();
                    FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(file);
                    FileInfo info = new FileInfo(file);
                    lStr.Add(file);
                    lStr.Add(info.LastAccessTime.ToString());
                    lStr.Add(info.CreationTime.ToString());
                    lStr.Add(info.LastWriteTime.ToString());
                    csv1.WriteLineToCsv(m_pathToCSV, lStr);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
