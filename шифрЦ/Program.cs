using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шифрЦ
{
    class Program
    {
        static void Main(string[] args)
        {

            string user = Console.ReadLine();

            Console.WriteLine(cipherC(user));

            Console.ReadLine();

        }
        static string cipherC(string user)
        {
            string result = "";
            for (int i = 0; i < user.Length; i++)
            {
                int userChar = user[i];

                if (!char.IsLetter(user[i]))
                {
                    result += user[i];
                    continue;
                }
                if (userChar > 87 && userChar < 91 || userChar > 119 && userChar < 123)
                {
                    result += Convert.ToChar(userChar - 23);
                    continue;
                }
                if (userChar > 1100 && userChar < 1104 || userChar > 1068 && userChar < 1072)
                {
                    result += Convert.ToChar(userChar - 29);
                    continue;
                }
                result += Convert.ToChar(userChar + 3);
            }
            return result;
        }
    }
}
