namespace SteamNative;

internal class SteamUtils : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamUtils(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

	public bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	public bool GetImageRGBA(int iImage, IntPtr pubDest, int nDestBufferSize) { }

	public bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

	public bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	public bool IsOverlayEnabled() { }

}

