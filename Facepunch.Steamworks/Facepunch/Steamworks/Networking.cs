namespace Facepunch.Steamworks;

public class Networking : IDisposable
{
	internal sealed class OnRecievedP2PData : MulticastDelegate
	{

		public OnRecievedP2PData(object object, IntPtr method) { }

		public override void Invoke(ulong steamid, Byte[] data, int dataLength, int channel) { }

	}

	internal enum SessionError
	{
		None = 0,
		NotRunningApp = 1,
		NoRightsToApp = 2,
		DestinationNotLoggedIn = 3,
		Timeout = 4,
		Max = 5,
	}

	private static Byte[] ReceiveBuffer; //Field offset: 0x0
	public OnRecievedP2PData OnP2PData; //Field offset: 0x10
	public Func<UInt64, Boolean> OnIncomingConnection; //Field offset: 0x18
	public Action<UInt64, SessionError> OnConnectionFailed; //Field offset: 0x20
	private List<Int32> ListenChannels; //Field offset: 0x28
	private Stopwatch UpdateTimer; //Field offset: 0x30
	internal SteamNetworking networking; //Field offset: 0x38

	private static Networking() { }

	internal Networking(BaseSteamworks steamworks, SteamNetworking networking) { }

	public override void Dispose() { }

	private void onP2PConnectionFailed(P2PSessionConnectFail_t o) { }

	private void onP2PConnectionRequest(P2PSessionRequest_t o) { }

	private bool ReadP2PPacket(int channel) { }

	public void Update() { }

}

