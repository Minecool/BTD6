namespace Antlr.Runtime;

public class MismatchedTokenException : RecognitionException
{
	private int expecting; //Field offset: 0xC0

	public int Expecting
	{
		 get { } //Length: 7
	}

	public MismatchedTokenException() { }

	public MismatchedTokenException(int expecting, IIntStream input) { }

	public int get_Expecting() { }

	public virtual string ToString() { }

}

