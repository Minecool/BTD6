namespace Antlr.Runtime.Tree;

public interface ITreeNodeStream : IIntStream
{

	public ITreeAdaptor TreeAdaptor
	{
		 get { } //Length: 0
	}

	public ITreeAdaptor get_TreeAdaptor() { }

	public object LT(int k) { }

	public string ToString(object start, object stop) { }

}

