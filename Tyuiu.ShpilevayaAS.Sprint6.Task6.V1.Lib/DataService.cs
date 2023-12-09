using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.Text.RegularExpressions;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task6.V1.Lib
{
    public class DataService : ISprint6Task6V1
    {
        public string CollectTextFromFile(string path)
        {
            string pattern = @"^\w+";

            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    var firstWord = Regex.Match(line, pattern);
                    string word = firstWord.ToString();
                    resStr = resStr + " " + word;

                }
            }

            return resStr;
        }
    }
}
