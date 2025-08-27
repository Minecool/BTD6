namespace Assets.Scripts.SocialSharing;

public interface ISocialProvider
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public TaskCompletionSource<SocialShareResult> tcs; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal void <ShareMessageAsync>b__0(ShareResult shareResult, string shareTarget) { }

	}


	public void ShareMessage(string message) { }

	public Task<SocialShareResult> ShareMessageAsync(string message) { }

	public void ShareMessageWithCallback(string message, ShareResultCallback callback) { }

}

