namespace Assets.Scripts.SocialSharing;

public class SocialManager
{
	internal sealed class OnSharedToClipboard : MulticastDelegate
	{

		public OnSharedToClipboard(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private static ISocialProvider _socialProvider; //Field offset: 0x0
	public const string DeepLinkBaseUrl = "https://join.btd6.com"; //Field offset: 0x0
	private static Nullable<Boolean> useCmShortCodes; //Field offset: 0x8

	private static ISocialProvider SocialProvider
	{
		private get { } //Length: 138
	}

	public SocialManager() { }

	public static void CopyData(string code, OnSharedToClipboard onCopiedToClipboard) { }

	private static ISocialProvider get_SocialProvider() { }

	private static string GetMessage(DeepLinkType deepLinkType, string code) { }

	public static void ShareCode(string code, DeepLinkType deepLinkType, OnSharedToClipboard onSharedToClipboard) { }

	public static Task<SocialShareResult> ShareCode(string code, DeepLinkType deepLinkType) { }

}

