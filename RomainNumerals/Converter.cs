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
        public string Convertir(uint arabic) {
            if (arabic > 3000 || arabic == 0)
                throw new ArgumentOutOfRangeException();

            if (arabic < 4)
                return new string('I', (int)arabic);

            // dicArabicRomain.Add(1, "I");
            //dicArabicRomain.Add(2, "II");
            dicArabicRomain.Add(5, "V");
            dicArabicRomain.Add(10, "X");
            dicArabicRomain.Add(100, "C");



            return dicArabicRomain.Single(x => x.Key == arabic).Value;
        }
    }
}
