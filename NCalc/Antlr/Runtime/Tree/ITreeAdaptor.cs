namespace Antlr.Runtime.Tree;

public interface ITreeAdaptor
{

	public void AddChild(object t, object child) { }

	public object Create(IToken payload) { }

	public object ErrorNode(ITokenStream input, IToken start, IToken stop, RecognitionException e) { }

	public object GetNilNode() { }

	public string GetNodeText(object t) { }

	public int GetNodeType(object t) { }

	public IToken GetToken(object treeNode) { }

	public object RulePostProcessing(object root) { }

	public void SetTokenBoundaries(object t, IToken startToken, IToken stopToken) { }

}

