namespace System.Xml.Serialization;

[DefaultMember("Item")]
public class XmlAnyElementAttributes : CollectionBase
{

	public XmlAnyElementAttribute Item
	{
		 get { } //Length: 288
	}

	internal int Order
	{
		internal get { } //Length: 476
	}

	public XmlAnyElementAttributes() { }

	public int Add(XmlAnyElementAttribute attribute) { }

	internal void AddKeyHash(StringBuilder sb) { }

	public XmlAnyElementAttribute get_Item(int index) { }

	internal int get_Order() { }

}

