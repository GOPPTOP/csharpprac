using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_3
{
     class Program
    {
        class CaesarShifr
        {
            private string strShifr;
            private int shift;
            public string GetShifr()
            {
                return strShifr;
            }
            public void SetShifr(string code, int shift)
            {
                this.strShifr = EncryptStr(code, shift);
                this.shift = shift;
            }
            private string EncryptStr(string code, int shift)
            {
                char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                char l;
                int index;
                string stringShifr = "";
                for (int i = 0; i < code.Length; i++)
                {

                    l = code[i];
                    if (l == ' ')
                    {
                        stringShifr += l;
                        continue;
                    }
                    index = Array.IndexOf(alphabet, l);
                    index += shift;
                    if (index > 32)
                    {
                        index -= 33;
                    }
                    else if (index < 0)
                    {
                        index += 33;
                    }
                    stringShifr += alphabet[index];
                }
                return stringShifr;
            }
        }
        static void Main(string[] args)
        {
            CaesarShifr myShifr = new CaesarShifr();
            myShifr.SetShifr("обед очки уютненько", 3);
            Console.WriteLine(myShifr.GetShifr());
            myShifr.SetShifr("ргжё рщмк хафпжпюмр", -2);
            Console.WriteLine(myShifr.GetShifr());
            Console.ReadKey(true);
        }
    }
}