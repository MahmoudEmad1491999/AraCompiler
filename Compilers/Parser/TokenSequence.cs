using System.Collections.Generic;
using Compilers.Scanner;

namespace Compilers.Parser {
    public class TokenSequence {
        public Token[] tokenString;
        public int consumed = 0;
        
        public TokenSequence(Token[] tokenString) 
        {
            this.tokenString = tokenString;
        }
        public bool hasNext() 
        { 
            return consumed < tokenString.Length;
        }

        public Token peekNextToken() 
        {
            if(consumed < tokenString.Length)
            {
                return tokenString[consumed];
            }else 
            {
                return null;
            }
        }

        public TokenType peekNextType() 
        {
            if(consumed < tokenString.Length)
            {
                return tokenString[consumed].tokenType;
            }else 

            {
                return TokenType.EOF;
            }
        }
        
        public void incConsumed() 
        {
            if(consumed < tokenString.Length)
            {
                consumed++;
            }
        }

    }
}