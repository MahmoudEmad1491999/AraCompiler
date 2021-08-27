namespace Compilers.Scanner
{
    public class Token
    {
        public TokenType tokenType;
        public int line;
        public string value;

        public Token(TokenType tokenType, int line)
        {
            this.tokenType = tokenType;
            this.line = line;
            this.value = "";
        }

        public Token(TokenType tokenType, int line, string value)
        {
            this.tokenType = tokenType;
            this.line = line;
            this.value = value;
        }

        public override string ToString()
        {
            return this.tokenType.ToString() + ": " +
            this.value +
            ", line: " + this.line;
        }


    }
}