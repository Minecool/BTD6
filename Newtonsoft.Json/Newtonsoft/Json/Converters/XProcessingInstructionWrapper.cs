namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XProcessingInstructionWrapper : XObjectWrapper
{

	public virtual string LocalName
	{
		 get { } //Length: 109
	}

	[Nullable(1)]
	private XProcessingInstruction ProcessingInstruction
	{
		[NullableContext(1)]
		private get { } //Length: 103
	}

	public virtual string Value
	{
		 get { } //Length: 109
	}

	[NullableContext(1)]
	public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction) { }

	public virtual string get_LocalName() { }

	[NullableContext(1)]
	private XProcessingInstruction get_ProcessingInstruction() { }

	public virtual string get_Value() { }

}

