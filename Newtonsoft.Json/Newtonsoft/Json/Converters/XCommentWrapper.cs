namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XCommentWrapper : XObjectWrapper
{

	public virtual IXmlNode ParentNode
	{
		 get { } //Length: 160
	}

	[Nullable(1)]
	private XComment Text
	{
		[NullableContext(1)]
		private get { } //Length: 103
	}

	public virtual string Value
	{
		 get { } //Length: 109
	}

	[NullableContext(1)]
	public XCommentWrapper(XComment text) { }

	public virtual IXmlNode get_ParentNode() { }

	[NullableContext(1)]
	private XComment get_Text() { }

	public virtual string get_Value() { }

}

