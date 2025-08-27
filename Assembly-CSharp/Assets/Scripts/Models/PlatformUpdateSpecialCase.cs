namespace Assets.Scripts.Models;

public class PlatformUpdateSpecialCase
{
	[CompilerGenerated]
	private readonly string <StoreName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Version <Version>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <ForceUpdate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <SuggestUpdate>k__BackingField; //Field offset: 0x21

	public bool ForceUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string StoreName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool SuggestUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Version Version
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[JsonConstructor]
	public PlatformUpdateSpecialCase(bool forceUpdate, bool suggestUpdate, string storeName, Version version) { }

	[CompilerGenerated]
	public bool get_ForceUpdate() { }

	[CompilerGenerated]
	public string get_StoreName() { }

	[CompilerGenerated]
	public bool get_SuggestUpdate() { }

	[CompilerGenerated]
	public Version get_Version() { }

}

