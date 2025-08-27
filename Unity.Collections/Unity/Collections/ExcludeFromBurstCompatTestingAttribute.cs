namespace Unity.Collections;

[AttributeUsage(224)]
public class ExcludeFromBurstCompatTestingAttribute : Attribute
{
	[CompilerGenerated]
	private string <Reason>k__BackingField; //Field offset: 0x10

	public string Reason
	{
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ExcludeFromBurstCompatTestingAttribute(string _reason) { }

	[CompilerGenerated]
	public void set_Reason(string value) { }

}

