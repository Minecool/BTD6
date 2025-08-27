namespace Antlr.Runtime;

public class FailedPredicateException : RecognitionException
{
	public string ruleName; //Field offset: 0xC0
	public string predicateText; //Field offset: 0xC8

	public FailedPredicateException() { }

	public virtual string ToString() { }

}

