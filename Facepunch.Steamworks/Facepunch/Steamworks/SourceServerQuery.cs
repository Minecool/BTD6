namespace Facepunch.Steamworks;

internal class SourceServerQuery : IDisposable
{
	public static List<SourceServerQuery> Current; //Field offset: 0x0
	private static readonly Byte[] A2S_SERVERQUERY_GETCHALLENGE; //Field offset: 0x8
	private static readonly byte A2S_RULES; //Field offset: 0x10
	public bool IsRunning; //Field offset: 0x10
	public bool IsSuccessful; //Field offset: 0x11
	private Server Server; //Field offset: 0x18
	private Thread thread; //Field offset: 0x20
	private Dictionary<String, String> rules; //Field offset: 0x28

	private static SourceServerQuery() { }

	public static void Cycle() { }

	public override void Dispose() { }

	private void Update() { }

}

