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
                       
            return null;
        }
    }
}