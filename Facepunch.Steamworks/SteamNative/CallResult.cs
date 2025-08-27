namespace SteamNative;

internal abstract class CallResult : CallbackHandle
{
	internal SteamAPICall_t Call; //Field offset: 0x40

	internal CallResult(BaseSteamworks steamworks, SteamAPICall_t call) { }

	internal abstract void RunCallback() { }

	internal void Try() { }

}

