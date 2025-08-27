namespace Assets.Scripts.SocialSharing;

[IsReadOnly]
public struct SocialShareResult
{
	[CompilerGenerated]
	private readonly string <ShareTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ShareResult <ShareResult>k__BackingField; //Field offset: 0x8

	public ShareResult ShareResult
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public string ShareTarget
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool Success
	{
		 get { } //Length: 8
	}

	public SocialShareResult(string shareTarget, ShareResult shareResult) { }

	[CompilerGenerated]
	public ShareResult get_ShareResult() { }

	[CompilerGenerated]
	public string get_ShareTarget() { }

	public bool get_Success() { }

}

