namespace Antlr.Runtime.Tree;

public class CommonTreeAdaptor : BaseTreeAdaptor
{

	public CommonTreeAdaptor() { }

	public virtual object Create(IToken payload) { }

	public virtual string GetNodeText(object t) { }

	public virtual int GetNodeType(object t) { }

	public virtual IToken GetToken(object treeNode) { }

	public virtual void SetTokenBoundaries(object t, IToken startToken, IToken stopToken) { }

}

