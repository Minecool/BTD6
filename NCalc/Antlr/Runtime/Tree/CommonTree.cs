namespace Antlr.Runtime.Tree;

public class CommonTree : BaseTree
{
	public int startIndex; //Field offset: 0x18
	public int stopIndex; //Field offset: 0x1C
	protected IToken token; //Field offset: 0x20
	public CommonTree parent; //Field offset: 0x28
	public int childIndex; //Field offset: 0x30

	public virtual int CharPositionInLine
	{
		 get { } //Length: 204
	}

	public virtual int ChildIndex
	{
		 set { } //Length: 4
	}

	public virtual bool IsNil
	{
		 get { } //Length: 9
	}

	public virtual int Line
	{
		 get { } //Length: 203
	}

	public virtual ITree Parent
	{
		 set { } //Length: 165
	}

	public virtual string Text
	{
		 get { } //Length: 76
	}

	public override IToken Token
	{
		 get { } //Length: 5
	}

	public virtual int TokenStartIndex
	{
		 set { } //Length: 4
	}

	public virtual int TokenStopIndex
	{
		 set { } //Length: 4
	}

	public virtual int Type
	{
		 get { } //Length: 73
	}

	public CommonTree() { }

	public CommonTree(IToken t) { }

	public virtual int get_CharPositionInLine() { }

	public virtual bool get_IsNil() { }

	public virtual int get_Line() { }

	public virtual string get_Text() { }

	public override IToken get_Token() { }

	public virtual int get_Type() { }

	public virtual void set_ChildIndex(int value) { }

	public virtual void set_Parent(ITree value) { }

	public virtual void set_TokenStartIndex(int value) { }

	public virtual void set_TokenStopIndex(int value) { }

	public virtual string ToString() { }

}

