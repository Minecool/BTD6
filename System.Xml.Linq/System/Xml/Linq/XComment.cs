namespace System.Xml.Linq;

public class XComment : XNode
{
	internal string value; //Field offset: 0x28

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string Value
	{
		 get { } //Length: 5
	}

	public XComment(string value) { }

	public XComment(XComment other) { }

	internal virtual XNode CloneNode() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_Value() { }

	public virtual void WriteTo(XmlWriter writer) { }

}

