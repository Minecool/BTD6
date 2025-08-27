namespace Antlr.Runtime.Tree;

public abstract class BaseTree : ITree
{
	protected IList children; //Field offset: 0x10

	public override int CharPositionInLine
	{
		 get { } //Length: 3
	}

	public override int ChildCount
	{
		 get { } //Length: 78
	}

	public override int ChildIndex
	{
		 set { } //Length: 3
	}

	public IList Children
	{
		 get { } //Length: 5
	}

	public override bool IsNil
	{
		 get { } //Length: 3
	}

	public override int Line
	{
		 get { } //Length: 3
	}

	public override ITree Parent
	{
		 set { } //Length: 3
	}

	public abstract string Text
	{
		 get { } //Length: 0
	}

	public abstract int TokenStartIndex
	{
		 set { } //Length: 0
	}

	public abstract int TokenStopIndex
	{
		 set { } //Length: 0
	}

	public abstract int Type
	{
		 get { } //Length: 0
	}

	public BaseTree() { }

	public override void AddChild(ITree t) { }

	protected private override IList CreateChildrenList() { }

	public override void FreshenParentAndChildIndexes() { }

	public override void FreshenParentAndChildIndexes(int offset) { }

	public override int get_CharPositionInLine() { }

	public override int get_ChildCount() { }

	public IList get_Children() { }

	public override bool get_IsNil() { }

	public override int get_Line() { }

	public abstract string get_Text() { }

	public abstract int get_Type() { }

	public override ITree GetChild(int i) { }

	public override void set_ChildIndex(int value) { }

	public override void set_Parent(ITree value) { }

	public abstract void set_TokenStartIndex(int value) { }

	public abstract void set_TokenStopIndex(int value) { }

	public abstract string ToString() { }

}

