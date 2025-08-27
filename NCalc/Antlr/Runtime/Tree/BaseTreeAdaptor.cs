namespace Antlr.Runtime.Tree;

public abstract class BaseTreeAdaptor : ITreeAdaptor
{
	protected int uniqueNodeID; //Field offset: 0x10

	protected BaseTreeAdaptor() { }

	public override void AddChild(object t, object child) { }

	public abstract object Create(IToken param1) { }

	public override object ErrorNode(ITokenStream input, IToken start, IToken stop, RecognitionException e) { }

	public override object GetNilNode() { }

	public override string GetNodeText(object t) { }

	public override int GetNodeType(object t) { }

	public abstract IToken GetToken(object treeNode) { }

	public override object RulePostProcessing(object root) { }

	public abstract void SetTokenBoundaries(object param1, IToken param2, IToken param3) { }

}

