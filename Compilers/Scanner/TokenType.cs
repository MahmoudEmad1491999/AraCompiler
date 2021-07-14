using System;

namespace Compilers.Scanner
{
    public enum TokenType
    {
        UNDEFINED,
        EOF,

        INT,
        UINT,

        IF,
        WHILE,

        FUNCTION,
        OPERATION,
        
        RESULT,
        REUTRN,


        IDENTIFIER,       
        ADD,
        SUB,
        MUL,
        DIV,
        FASLA,
        FASLANOQTA,
        RCURLY,
        LCURLY,
        RBOW,
        LBOW,
        RSQUARE,
        LSQUARE,
        ASSIGN,        


    }
}
