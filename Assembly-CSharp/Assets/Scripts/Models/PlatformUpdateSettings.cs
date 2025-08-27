namespace Assets.Scripts.Models;

public class PlatformUpdateSettings
{
	[CompilerGenerated]
	private readonly Version <RequiredVersion>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Version <SuggestedVersion>k__BackingField; //Field offset: 0x18

	public Version RequiredVersion
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Version SuggestedVersion
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[JsonConstructor]
	public PlatformUpdateSettings(Version requiredVersion, Version suggestedVersion) { }

	[CompilerGenerated]
	public Version get_RequiredVersion() { }

	[CompilerGenerated]
	public Version get_SuggestedVersion() { }

}

