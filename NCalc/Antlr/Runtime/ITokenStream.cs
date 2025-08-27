namespace Antlr.Runtime;

public interface ITokenStream : IIntStream
{

	public IToken LT(int k) { }

	public string ToString(int start, int stop) { }

}

