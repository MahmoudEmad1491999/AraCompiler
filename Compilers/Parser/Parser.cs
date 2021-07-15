using System;
using Compilers.Scanner;

namespace Compilers.Parser
{
    public class parser
    {
        public TokenSequence tokenSequence;

        public parser (TokenSequence tokenSequence) {
            this.tokenSequence = tokenSequence;            
        }

        public Node parse() {
            Node head = parseExpression();
            return head;
        }


        public Node parseExpression() 
        {
            if(tokenSequence.peekNextType() == TokenType.IDENTIFIER)
            {
                tokenSequence.consumed++;
                return new Id(tokenSequence.peekNextToken().value);
            }
            return null;
        }
    }
}