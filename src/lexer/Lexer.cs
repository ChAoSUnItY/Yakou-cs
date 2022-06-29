using System.Collections.Generic;

namespace org.yakou.lang {
    public class Lexer {
        private List<string>? OriginalString { get; set; }
        private string? _currentString;
        private int Line { get; set; }
        private int Pos { get; set; }
        
        public Lexer() {
        }

        public void lex(List<string> originalString)
        {
            OriginalString = originalString;

            while (Line < OriginalString.Count)
            {
                _currentString = OriginalString[Line];

                while (Pos < _currentString.Length)
                {
                    // Lex stuff here 
                }
            }

            Pos = 0;
            Line++;
        }
    }
}