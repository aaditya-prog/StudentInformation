using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    public static class Utility
    {
        private static string _filePath = "student.txt";

        public static string WriteToText(string data)
        {
            if (!File.Exists(_filePath))
            {
                using (File.Create(_filePath)) ;
            }
            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);

            }
            return "Success";

        }
    }
}
