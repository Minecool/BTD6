namespace System.Reflection;

[AttributeUsage(8157, AllowMultiple = True, Inherited = False)]
public sealed class ObfuscationAttribute : Attribute
{
	[CompilerGenerated]
	private bool <StripAfterObfuscation>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Exclude>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <ApplyToMembers>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private string <Feature>k__BackingField; //Field offset: 0x18

	public bool Exclude
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Feature
	{
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ObfuscationAttribute() { }

	[CompilerGenerated]
	public void set_Exclude(bool value) { }

	[CompilerGenerated]
	public void set_Feature(string value) { }

}

