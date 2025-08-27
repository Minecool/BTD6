namespace Unity.IL2CPP.CompilerServices;

[AttributeUsage(4301, Inherited = False, AllowMultiple = True)]
public class Il2CppSetOptionAttribute : Attribute
{
	[CompilerGenerated]
	private Option <Option>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private object <Value>k__BackingField; //Field offset: 0x18

	public private Option Option
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private object Value
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Il2CppSetOptionAttribute(Option option, object value) { }

	[CompilerGenerated]
	public Option get_Option() { }

	[CompilerGenerated]
	public object get_Value() { }

	[CompilerGenerated]
	private void set_Option(Option value) { }

	[CompilerGenerated]
	private void set_Value(object value) { }

}

