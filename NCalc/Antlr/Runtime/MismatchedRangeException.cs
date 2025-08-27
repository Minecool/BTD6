namespace Antlr.Runtime;

public class MismatchedRangeException : RecognitionException
{
	private int a; //Field offset: 0xC0
	private int b; //Field offset: 0xC4

	public int A
	{
		 get { } //Length: 7
	}

	public int B
	{
		 get { } //Length: 7
	}

	public MismatchedRangeException() { }

	public MismatchedRangeException(int a, int b, IIntStream input) { }

	public int get_A() { }

	public int get_B() { }

	public virtual string ToString() { }

}

