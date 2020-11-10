using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Security.Cryptography;
namespace FLSGUI
{
    class manage_file
    {
        string m_pathFile;
        public manage_file(string path)
        {
            m_pathFile = path;
        }
        string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
         string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                try
                {
                    using (var stream = File.OpenRead(filename))
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                catch (System.Security.SecurityException ex) { Console.WriteLine(ex.ToString()); return ""; }
            }
        }




        public Dictionary<string,string> get_file_info(string fileAbsPath) // get all info from file
        {

            string file = fileAbsPath;
            try
            {
                if (File.Exists(file) && ! string.IsNullOrEmpty(file))
                {
                    FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(file);
                    FileInfo info = new FileInfo(file);
                    Dictionary<string,string> tabInfoFile = new Dictionary<string, string>()
                    {
                        {"Name",info.Name },
                        {"Extension",info.Extension},
                        {"Path", myFileVersionInfo.FileName }, //full path
                        {"Description", myFileVersionInfo.FileDescription },
                        {"IsPatched", myFileVersionInfo.IsPatched.ToString() },
                        {"Editor", myFileVersionInfo.CompanyName },
                        {"FileVersion", myFileVersionInfo.FileVersion },
                        {"lastAccesTime", info.LastAccessTimeUtc.ToString() },
                       // {"isTrusted", AuthenticodeTools.IsTrusted(file).ToString() },
                        {"md5", CalculateMD5(file) }
                    };
                    return tabInfoFile;
                }
                else
                {
                    return null;
                }
            } catch(Exception ex){ Console.WriteLine(ex.Message); ;return null; }
      
        }
    }
}
