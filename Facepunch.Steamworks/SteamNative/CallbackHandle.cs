namespace SteamNative;

internal class CallbackHandle : IDisposable
{
	internal BaseSteamworks Steamworks; //Field offset: 0x10
	internal GCHandle FuncA; //Field offset: 0x18
	internal GCHandle FuncB; //Field offset: 0x20
	internal GCHandle FuncC; //Field offset: 0x28
	internal IntPtr vTablePtr; //Field offset: 0x30
	internal GCHandle PinnedCallback; //Field offset: 0x38

	internal CallbackHandle(BaseSteamworks steamworks) { }

	public override void Dispose() { }

	private void UnregisterCallback() { }

}

