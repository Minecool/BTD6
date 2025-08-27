namespace Antlr.Runtime;

public class UnwantedTokenException : MismatchedTokenException
{

	public IToken UnexpectedToken
	{
		 get { } //Length: 8
	}

	public UnwantedTokenException(int expecting, IIntStream input) { }

	public IToken get_UnexpectedToken() { }

	public virtual string ToString() { }

}

