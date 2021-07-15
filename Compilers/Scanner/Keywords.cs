using System;
using System.Collections.Generic;
namespace Compilers.Scanner
{
    public static class Keywords
    {
        public static List<string> values;
        static Keywords() {
            values = new List<string>();
            values.Add("صحيح");
            values.Add("طبيعي");
            values.Add("دالة");
            values.Add("عملية");
            values.Add("إذا");
            values.Add("طالما");
            values.Add("رجوع");
            values.Add("الناتج");
            
        }
        public static TokenType GetTokenType(string str) {
            switch(str){
                case "صحيح":
                return TokenType.INT;
                case "طبيعي":
                return TokenType.UINT;
                case "دالة":
                return TokenType.FUNCTION;
                case "عملية":
                return TokenType.OPERATION;
                case "إذا":
                return TokenType.IF;
                case "طالما":
                return TokenType.WHILE;
                case "رجوع":
                return TokenType.REUTRN;
                case "الناتج":
                return TokenType.RESULT;
                default:
                return TokenType.UNDEFINED;
            }
        }
    }
}
