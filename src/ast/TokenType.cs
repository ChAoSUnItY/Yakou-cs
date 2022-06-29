namespace org.yakou.lang.ast;

public class TokenType
{
    public string? Literal { get; }

    public TokenType(string? literal)
    {
        Literal = literal;
    }
    
    public static readonly TokenType Identifier = new(null);
}