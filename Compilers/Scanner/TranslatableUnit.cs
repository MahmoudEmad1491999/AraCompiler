using System;

namespace Compilers.Scanner
{
    public class TranslationUnit
    {
        public string text;
        public int consumed;

        public int countedLines;
        public TranslationUnit(string text)
        {
            this.text = text;
            this.consumed = 0;
            this.countedLines = 1;
        }

        public bool hasnext()
        {
            return this.consumed < this.text.Length;
        }

        public char getNextChar()
        {
            if (this.consumed < this.text.Length)
            {
                return this.text[consumed++];
            }
            else
            {
                return '\0';
            }
        }
        public char peek()
        {
            if (this.consumed < this.text.Length)
            {
                return this.text[consumed];
            }
            else
            {
                return '\0';
            }
        }
        public bool nextIs(char input)
        {
            if (this.consumed < this.text.Length)
            {
                return this.text[consumed] == input;
            }
            else
            {
                return false;
            }
        }
        public bool nextIs(string input)
        {
            if (this.text.Length - this.consumed >= input.Length)
            {

                int input_length = input.Length;
                for (int index = 0; index < input_length; index++)
                {
                    if (this.text[consumed + index] != input[index]) return false;
                }
                return true;
            }
            return false;
        }

        public bool incConsumed()
        {
            if (this.consumed < this.text.Length)
            {
                consumed++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void incCountedLines()
        {
            this.countedLines++;
        }
        public void incConsumedBy(int count)
        {
            this.consumed += count;
        }
        public bool nextIsIdenStart()
        {
            if (this.consumed < this.text.Length)
            {
                switch (this.text[consumed])
                {
                    case 'ا':
                    case 'ب':
                    case 'ت':
                    case 'ث':
                    case 'ج':
                    case 'ح':
                    case 'خ':
                    case 'د':
                    case 'ذ':
                    case 'ر':
                    case 'ز':
                    case 'س':
                    case 'ش':
                    case 'ص':
                    case 'ض':
                    case 'ط':
                    case 'ظ':
                    case 'ع':
                    case 'غ':
                    case 'ف':
                    case 'ق':
                    case 'ك':
                    case 'ل':
                    case 'م':
                    case 'ن':
                    case 'ه':
                    case 'ة':
                    case 'و':
                    case 'ي':
                    case 'ى':
                    case 'آ':
                    case 'أ':
                    case 'إ':
                    case 'ئ':
                    case '؟':
                    case '_':
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool nextIsIdenInternal(){
            if (this.consumed < this.text.Length)
            {
                switch (this.text[consumed])
                {
                    case 'ا':
                    case 'ب':
                    case 'ت':
                    case 'ث':
                    case 'ج':
                    case 'ح':
                    case 'خ':
                    case 'د':
                    case 'ذ':
                    case 'ر':
                    case 'ز':
                    case 'س':
                    case 'ش':
                    case 'ص':
                    case 'ض':
                    case 'ط':
                    case 'ظ':
                    case 'ع':
                    case 'غ':
                    case 'ف':
                    case 'ق':
                    case 'ك':
                    case 'ل':
                    case 'م':
                    case 'ن':
                    case 'ه':
                    case 'ة':
                    case 'و':
                    case 'ي':
                    case 'ى':
                    case 'آ':
                    case 'أ':
                    case 'إ':
                    case 'ئ':
                    case '؟':
                    case '_':
                    case '٠' :
                    case '١' :
                    case '٢' :
                    case '٣' :
                    case '٤' :
                    case '٥' :
                    case '٦' :
                    case '٧' :
                    case '٨' :
                    case '٩' :
                    case '0' :
                    case '1' :
                    case '2' :
                    case '3' :
                    case '4' :
                    case '5' :
                    case '6' :
                    case '7' :
                    case '8' :
                    case '9' :
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
