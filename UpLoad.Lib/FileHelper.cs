using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UpLoad.Lib
{
    public class FileHelper
    {
        public static string GetFileSizeString(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return GetFileSizeString(fs.Length);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                GC.Collect();
            }

        }
        public static string GetFileSizeString(long l)
        {
            double b = l;
            double kb = l / 1024D;
            double mb = l / (1024 * 1024D);
            double gb = l / (1024 * 1024 * 1024D);
            double tb = l / (1024 * 1024 * 1024 * 1024D);
            double pb = l / (1024 * 1024 * 1024 * 1024L * 1024D);
            if (kb < 1)
            {
                return $"{b:N2}b";
            }
            if (mb < 1)
            {
                return $"{kb:N2}kb";
            }
            if (gb < 1)
            {
                return $"{mb:N2}mb";
            }
            if (tb < 1)
            {
                return $"{gb:N2}gb";
            }
            if (pb < 1)
            {
                return $"{tb:N2}tb";
            }
            return "";
        }
    }
}
