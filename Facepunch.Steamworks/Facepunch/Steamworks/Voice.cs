namespace Facepunch.Steamworks;

public class Voice
{
	private const int ReadBufferSize = 131072; //Field offset: 0x0
	internal Client client; //Field offset: 0x10
	internal Byte[] ReadCompressedBuffer; //Field offset: 0x18
	internal Byte[] ReadUncompressedBuffer; //Field offset: 0x20
	internal Byte[] UncompressBuffer; //Field offset: 0x28
	public Action<Byte[], Int32> OnCompressedData; //Field offset: 0x30
	public Action<Byte[], Int32> OnUncompressedData; //Field offset: 0x38
	private Stopwatch UpdateTimer; //Field offset: 0x40
	private bool _wantsrecording; //Field offset: 0x48
	[CompilerGenerated]
	private DateTime <LastVoiceRecordTime>k__BackingField; //Field offset: 0x50
	public bool IsRecording; //Field offset: 0x58
	public uint DesiredSampleRate; //Field offset: 0x5C

	private DateTime LastVoiceRecordTime
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public uint OptimalSampleRate
	{
		 get { } //Length: 47
	}

	internal Voice(Client client) { }

	public uint get_OptimalSampleRate() { }

	[CompilerGenerated]
	private void set_LastVoiceRecordTime(DateTime value) { }

	public void Update() { }

}

