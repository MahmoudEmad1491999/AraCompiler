namespace Compilers.Scanner 
{
    public class Token {
        public TokenType tokenType;
        public int line;
        public object value;

        public Token(TokenType tokenType, int line){
            this.tokenType = tokenType;
            this.line = line;
            this.value = null;
        }

        public Token(TokenType tokenType, int line, object value)
        {
            this.tokenType = tokenType;
            this.line = line;
            this.value = value;
        }

        public override string ToString()
        {
            return this.tokenType.ToString() + ": " +
            (this.value ?? "\"\"" )+
            ", line: " + this.line;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
    }
}