namespace Antlr.Runtime;

public class CommonToken : IToken
{
	protected private int type; //Field offset: 0x10
	protected private int line; //Field offset: 0x14
	protected private int charPositionInLine; //Field offset: 0x18
	protected private int channel; //Field offset: 0x1C
	protected private ICharStream input; //Field offset: 0x20
	protected private string text; //Field offset: 0x28
	protected private int index; //Field offset: 0x30
	protected private int start; //Field offset: 0x34
	protected private int stop; //Field offset: 0x38

	public override int Channel
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override int CharPositionInLine
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override int Line
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override string Text
	{
		 get { } //Length: 101
		 set { } //Length: 5
	}

	public override int TokenIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override int Type
	{
		 get { } //Length: 94
	}

	public CommonToken(int type) { }

	public CommonToken(ICharStream input, int type, int channel, int start, int stop) { }

	public CommonToken(int type, string text) { }

	public override int get_Channel() { }

	public override int get_CharPositionInLine() { }

	public override int get_Line() { }

	public override string get_Text() { }

	public override int get_TokenIndex() { }

	public override int get_Type() { }

	public override void set_Channel(int value) { }

	public override void set_CharPositionInLine(int value) { }

	public override void set_Line(int value) { }

	public override void set_Text(string value) { }

	public override void set_TokenIndex(int value) { }

	public virtual string ToString() { }

}

