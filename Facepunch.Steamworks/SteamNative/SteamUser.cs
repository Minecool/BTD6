namespace SteamNative;

internal class SteamUser : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	public bool IsValid
	{
		 get { } //Length: 75
	}

	internal SteamUser(BaseSteamworks steamworks, IntPtr pointer) { }

	public void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	public override void Dispose() { }

	public bool get_IsValid() { }

	public HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket) { }

	public VoiceResult GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	public ulong GetSteamID() { }

	public string GetUserDataFolder() { }

	public VoiceResult GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, out uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	public uint GetVoiceOptimalSampleRate() { }

}

