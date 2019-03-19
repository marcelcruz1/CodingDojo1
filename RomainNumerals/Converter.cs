using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomainNumerals
{
    public class Converter
    {
        private readonly IDictionary<uint, string> dicArabicRomain = new Dictionary<uint, string>();
        public string Convertir(uint arabic)
        {
            if (arabic > 3000)
                throw new ArgumentOutOfRangeException();

            var dict = new Dictionary<uint, string>();

            dict.Add(1000, "M");
            dict.Add(900, "CM");
            dict.Add(500, "D");
            dict.Add(400, "CD");
            dict.Add(100, "C");
            dict.Add(90, "XC");
            dict.Add(50, "L");
            dict.Add(40, "XL");
            dict.Add(10, "X");
            dict.Add(9, "IX");
            dict.Add(5, "V");
            dict.Add(4, "IV");
            dict.Add(1, "I");

            foreach (var item in dict)
            {
                if (arabic >= item.Key)
                    return item.Value + this.Convertir(arabic - item.Key);
            }
           

            return "";
        }
    }
}
