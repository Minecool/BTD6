namespace Antlr.Runtime.Tree;

public interface ITree
{

	public int CharPositionInLine
	{
		 get { } //Length: 0
	}

	public int ChildCount
	{
		 get { } //Length: 0
	}

	public int ChildIndex
	{
		 set { } //Length: 0
	}

	public bool IsNil
	{
		 get { } //Length: 0
	}

	public int Line
	{
		 get { } //Length: 0
	}

	public ITree Parent
	{
		 set { } //Length: 0
	}

	public string Text
	{
		 get { } //Length: 0
	}

	public int TokenStartIndex
	{
		 set { } //Length: 0
	}

	public int TokenStopIndex
	{
		 set { } //Length: 0
	}

	public int Type
	{
		 get { } //Length: 0
	}

	public void AddChild(ITree t) { }

	public int get_CharPositionInLine() { }

	public int get_ChildCount() { }

	public bool get_IsNil() { }

	public int get_Line() { }

	public string get_Text() { }

	public int get_Type() { }

	public ITree GetChild(int i) { }

	public void set_ChildIndex(int value) { }

	public void set_Parent(ITree value) { }

	public void set_TokenStartIndex(int value) { }

	public void set_TokenStopIndex(int value) { }

}

