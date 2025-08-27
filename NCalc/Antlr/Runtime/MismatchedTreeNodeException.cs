namespace Antlr.Runtime;

public class MismatchedTreeNodeException : RecognitionException
{
	public int expecting; //Field offset: 0xC0

	public MismatchedTreeNodeException() { }

	public virtual string ToString() { }

}

