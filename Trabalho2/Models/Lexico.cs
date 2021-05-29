using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Models
{
    public class Lexico : Constants
    {
        
        private int position;
        private String input;

        public Lexico()
        {
           
            new System.IO.StringReader("");
        }
        public Lexico(System.IO.StreamReader input)
        {
            setInput(input);
        }


        public void setInput(System.IO.StreamReader input)
        {
            StringBuilder bfr = new StringBuilder();
            try
            {
                int c = input.Read();
                while (c != -1)
                {
                    bfr.Append((char)c);
                    c = input.Read();
                }
                this.input = bfr.ToString();
            }
            catch (System.IO.IOException e)
            {
               var ex= e.Message;
            }

            setPosition(0);
        }
        public void setPosition(int pos)
        {
            position = pos;
        }


        public Token nextToken()
        {
        if (!hasInput() )
            return null;

        int start = position;

        int state = 0;
        int lastState = 0;
        int endState = -1;
        int end = -1;

        while (hasInput())
        {
            lastState = state;
            state = nextState(nextChar(), state);

            if (state< 0)
                break;

            else
            {
                if (tokenForState(state) >= 0)
                {
                    endState = state;
                    end = position;
                }
}
        }
        if (endState< 0 || (endState != state && tokenForState(lastState) == -2))
            throw new LexicalError(SCANNER_ERROR[lastState], start);

        position = end;

        int token = tokenForState(endState);

        if (token == 0)
            return nextToken();
        else
        {
            String lexeme = input.Substring(start, end);
            return new Token(token, lexeme, start);
        }
    }
        private int nextState(char c, int state)
        {
            int start = SCANNER_TABLE_INDEXES[state];
            int end = SCANNER_TABLE_INDEXES[state + 1] - 1;

            while (start <= end)
            {
                int half = (start + end) / 2;

                if (SCANNER_TABLE[half,0] == c)
                    return SCANNER_TABLE[half,1];
                else if (SCANNER_TABLE[half,0] < c)
                    start = half + 1;
                else  //(SCANNER_TABLE[half][0] > c)
                    end = half - 1;
            }

            return -1;
        }


        private int tokenForState(int state)
        {
            if (state < 0 || state >= TOKEN_STATE.Length)
                return -1;

            return  TOKEN_STATE[state];
        }

        private Boolean hasInput()
        {
            return position < input.Length;
        }

      
        private char nextChar()
        {
            if (hasInput())
                return input.ElementAt(position++);
            else
                return Convert.ToChar(- 1);
        }
    }
}
