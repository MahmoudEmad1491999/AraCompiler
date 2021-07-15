using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using Compilers.Scanner;

using Compilers.Parser;
namespace Compilers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fullName = "C:\\Users\\NOMMRHNE\\Documents\\csharp\\AraCompiler\\Compilers\\test_cases\\file.arac";
            
            Console.WriteLine(fullName);

            string text = File.ReadAllText(fullName);
            Console.WriteLine(text);


            TranslationUnit translation_unit = new TranslationUnit(text);
            
            Tokenizer tokenizer = new Tokenizer(translation_unit);

            List<Token> token_list = tokenizer.getTokens();
            


            TokenSequence ts = new TokenSequence(token_list.ToArray());
            foreach(var token in ts.tokenString) 
            {
                Console.WriteLine(token);
            }
            
            return;
        }
    }
}
