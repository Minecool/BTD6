namespace Antlr.Runtime;

public class MissingTokenException : MismatchedTokenException
{
	private object inserted; //Field offset: 0xC8

	public int MissingType
	{
		 get { } //Length: 7
	}

	public MissingTokenException() { }

	public MissingTokenException(int expecting, IIntStream input, object inserted) { }

	public int get_MissingType() { }

	public virtual string ToString() { }

}

