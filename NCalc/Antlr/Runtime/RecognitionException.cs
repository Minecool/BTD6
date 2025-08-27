namespace Antlr.Runtime;

public class RecognitionException : Exception
{
	protected IIntStream input; //Field offset: 0x90
	protected int index; //Field offset: 0x98
	protected IToken token; //Field offset: 0xA0
	protected object node; //Field offset: 0xA8
	protected int c; //Field offset: 0xB0
	protected int line; //Field offset: 0xB4
	protected int charPositionInLine; //Field offset: 0xB8
	public bool approximateLineInfo; //Field offset: 0xBC

	public int Char
	{
		 get { } //Length: 7
	}

	public int CharPositionInLine
	{
		 get { } //Length: 7
	}

	public int Line
	{
		 get { } //Length: 7
	}

	public object Node
	{
		 get { } //Length: 8
	}

	public IToken Token
	{
		 get { } //Length: 8
	}

	public override int UnexpectedType
	{
		 get { } //Length: 314
	}

	public RecognitionException() { }

	public RecognitionException(string message) { }

	public RecognitionException(IIntStream input) { }

	public RecognitionException(string message, Exception inner, IIntStream input) { }

	protected void ExtractInformationFromTreeNodeStream(IIntStream input) { }

	public int get_Char() { }

	public int get_CharPositionInLine() { }

	public int get_Line() { }

	public object get_Node() { }

	public IToken get_Token() { }

	public override int get_UnexpectedType() { }

}

