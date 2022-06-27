using System.Collections.Generic;

namespace org.yakou.lang {
    public class Lexer {
        private List<string>? OriginalString { get; set; }
        private string? CurrentString;
        private int Line { get; set; }
        private int Pos { get; set; }
        
        public Lexer() {
        }

        public void lex(List<string> originalString)
        {
            OriginalString = originalString;

            while (Line < OriginalString.Count)
            {
                CurrentString = OriginalString[Line];

                while (Pos < CurrentString.Length)
                {
                    // Lex stuff here 
                }
            }

            Pos = 0;
            Line++;
        }
    }
}