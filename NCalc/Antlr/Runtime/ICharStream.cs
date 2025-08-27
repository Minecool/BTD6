namespace Antlr.Runtime;

public interface ICharStream : IIntStream
{

	public int CharPositionInLine
	{
		 get { } //Length: 0
	}

	public int Line
	{
		 get { } //Length: 0
	}

	public int get_CharPositionInLine() { }

	public int get_Line() { }

	public string Substring(int start, int stop) { }

}

