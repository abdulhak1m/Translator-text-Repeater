using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string data;
                Console.WriteLine("1: перевести текст в двочиный код;");
                Console.WriteLine("2: перевести бинарный код в текст;");
                int Action;
                while((Action = Convert.ToInt32(Console.ReadLine())) != 3)
                {
                    switch (Action) 
                    {
                        case 1:
                            Console.WriteLine("Введите текст!");
                            data = Console.ReadLine();
                            Console.WriteLine(StringToBinary(data));
                            break;
                        case 2:
                            Console.WriteLine("Двоичный код!");
                            data = Console.ReadLine();
                            Console.WriteLine(BinaryToString(data));
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message, ex.Source);
            }
        }
        public static string BinaryToString(string data)
        {
            List<byte> byteList = new List<byte>();
            for(int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
    }
}
