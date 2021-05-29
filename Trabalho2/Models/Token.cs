using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Models
{
    public class Token
    {
        private int id;
        private String lexeme;
        private int position;

        public Token(int id, String lexeme, int position)
        {
            this.id = id;
            this.lexeme = lexeme;
            this.position = position;
        }

        public  int getId()
        {
            return id;
        }

        public  String getLexeme()
        {
            return lexeme;
        }

        public  int getPosition()
        {
            return position;
        }

        public String toString()
        {
            return id + " ( " + lexeme + " ) @ " + position;
        }
    }
}
