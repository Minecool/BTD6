namespace Facepunch.Steamworks;

public class Workshop : IDisposable
{
	[ThreadStatic]
	private static UInt64[] _sSubscribedItemBuffer; //Field offset: 0x80000000
	internal const ulong InvalidHandle = 18446744073709551615; //Field offset: 0x0
	internal SteamUGC ugc; //Field offset: 0x10
	internal Friends friends; //Field offset: 0x18
	internal BaseSteamworks steamworks; //Field offset: 0x20
	internal SteamRemoteStorage remoteStorage; //Field offset: 0x28
	[CompilerGenerated]
	private Action<UInt64, Result> OnFileDownloaded; //Field offset: 0x30
	[CompilerGenerated]
	private Action<UInt64> OnItemInstalled; //Field offset: 0x38

	internal Workshop(BaseSteamworks steamworks, SteamUGC ugc, SteamRemoteStorage remoteStorage) { }

	public override void Dispose() { }

	private void onDownloadResult(DownloadItemResult_t obj) { }

	private void onItemInstalled(ItemInstalled_t obj) { }

}

