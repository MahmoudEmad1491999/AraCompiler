using System.Text;
using System.Collections.Generic;
namespace Compilers.Scanner
{

    public class Tokenizer
    {
        TranslatioConsole.WriteLine(ts.peekNextToken());nUnit translationUnit;

        public                  Tokenizer(TranslationUnit translationUnit)
        {
            this.translationUnit = translationUnit;
        }
        public  List<Token>     getTokens() 
        {
            List<Token> result = new List<Token>();
            Token temp = getNextToken();
            while(temp.tokenType != TokenType.UNDEFINED && temp.tokenType != TokenType.EOF){
                result.Add(temp);
                temp = getNextToken();
            }
            return result;
        }
        private Token           getNextToken()
        {
            if (translationUnit.hasnext())
            {
                if (translationUnit.nextIs('+'))
                {
                    translationUnit.incConsumed();
                    return new Token(TokenType.ADD, translationUnit.countedLines);
                }
                else if (translationUnit.nextIs('-'))
                {
                    translationUnit.incConsumed();
                    return new Token(TokenType.SUB, translationUnit.countedLines);
                }
                else if (translationUnit.nextIs('*'))
                {
                    translationUnit.incConsumed();
                    return new Token(TokenType.MUL, translationUnit.countedLines);
                }
                else if (translationUnit.nextIs('/'))
                {
                    translationUnit.incConsumed();
                    return new Token(TokenType.DIV, translationUnit.countedLines);
                }
                else if( translationUnit.nextIs(":=") ){
                    translationUnit.incConsumedBy(":=".Length);
                    return new Token(TokenType.ASSIGN, translationUnit.countedLines);
                }
                else if(translationUnit.nextIs('{')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.LCURLY, translationUnit.countedLines);
                }
                else if(translationUnit.nextIs('}')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.RCURLY, translationUnit.countedLines);
                }
                else if(translationUnit.nextIs('(')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.LBOW, translationUnit.countedLines);
                }
                else if(translationUnit.nextIs(')')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.RBOW, translationUnit.countedLines);
                }
                else if(translationUnit.nextIs('[')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.LSQUARE, translationUnit.countedLines);
                }
                else if(translationUnit.nextIs(']')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.RSQUARE, translationUnit.countedLines);
                }
                else if(translationUnit.nextIs('؛')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.FASLANOQTA, translationUnit.countedLines);
                }
                else if(translationUnit.nextIs('،')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.FASLA, translationUnit.countedLines);
                }
                else if (translationUnit.nextIsIdenStart()) {
                    return handleIdentifiers();
                }
                else if(translationUnit.nextIs('\0')){
                    translationUnit.incConsumed();
                    return new Token(TokenType.EOF, translationUnit.countedLines);
                }        
                else if (translationUnit.nextIs(' ') || translationUnit.nextIs('\t'))
                {
                    handleWhiteSpaces();
                    return getNextToken();
                }
                else if (translationUnit.nextIs('\n'))
                {
                    handleNewLines();
                    return getNextToken();
                }else{
                    return new Token(TokenType.UNDEFINED, translationUnit.countedLines);
                }
            }
            else
            {
                return new Token(TokenType.EOF, translationUnit.countedLines);
            }
        }
        private Token           handleIdentifiers()
        {
            StringBuilder possible_identifer_builder = new StringBuilder();
            
            if(translationUnit.nextIsIdenStart()){
                possible_identifer_builder.Append(translationUnit.getNextChar());
            }

            while(translationUnit.nextIsIdenInternal())
            {
                possible_identifer_builder.Append(translationUnit.getNextChar());
            }
            string possible_identifer = possible_identifer_builder.ToString();

            if(Keywords.values.Contains(possible_identifer)){
                return new Token(Keywords.GetTokenType(possible_identifer), translationUnit.countedLines);
            }
            else {
                return new Token(TokenType.IDENTIFIER, translationUnit.countedLines, possible_identifer);
            }
        }
        private void            handleNewLines()
        {
            while(translationUnit.nextIs('\n')){
                translationUnit.incConsumed();
                translationUnit.incCountedLines();
            }
        }
        private void            handleWhiteSpaces()
        {
            while(translationUnit.nextIs(' ') || translationUnit.nextIs('\t')){
                translationUnit.incConsumed();
            }
        }
    }
}
