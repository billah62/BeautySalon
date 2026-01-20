using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Extention
{
    public class CommonFunc
    {
        public static string GetCustomerCode()
        {
            string code = GenerateRandomString(4)
                + DateTime.Now.ToString("yyMMddHHmmss"); // write your own formula
            return code;
        }
        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }

            return new string(result);
        }
    }
}