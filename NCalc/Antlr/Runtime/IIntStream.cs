namespace Antlr.Runtime;

public interface IIntStream
{

	public int Count
	{
		 get { } //Length: 0
	}

	public void Consume() { }

	public int get_Count() { }

	public int Index() { }

	public int LA(int i) { }

	public int Mark() { }

	public void Rewind(int marker) { }

	public void Seek(int index) { }

}

