using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    public class GenerateString
    {
        private char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        
        public string genString(int size)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Random random = new Random();
            for(int i = 0;i<size;i++)
            {
                stringBuilder.Append(alphabet[random.Next(alphabet.Length-1)]);             
            }

            return stringBuilder.ToString();
        }
    
    }
}
