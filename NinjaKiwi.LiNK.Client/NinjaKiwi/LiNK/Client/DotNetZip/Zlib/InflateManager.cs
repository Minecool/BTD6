namespace NinjaKiwi.LiNK.Client.DotNetZip.Zlib;

internal sealed class InflateManager
{
	private enum InflateManagerMode
	{
		METHOD = 0,
		FLAG = 1,
		DICT4 = 2,
		DICT3 = 3,
		DICT2 = 4,
		DICT1 = 5,
		DICT0 = 6,
		BLOCKS = 7,
		CHECK4 = 8,
		CHECK3 = 9,
		CHECK2 = 10,
		CHECK1 = 11,
		DONE = 12,
		BAD = 13,
	}

	private const int PRESET_DICT = 32; //Field offset: 0x0
	private const int Z_DEFLATED = 8; //Field offset: 0x0
	private static readonly Byte[] mark; //Field offset: 0x0
	private InflateManagerMode mode; //Field offset: 0x10
	internal ZlibCodec _codec; //Field offset: 0x18
	internal int method; //Field offset: 0x20
	internal uint computedCheck; //Field offset: 0x24
	internal uint expectedCheck; //Field offset: 0x28
	internal int marker; //Field offset: 0x2C
	private bool _handleRfc1950HeaderBytes; //Field offset: 0x30
	internal int wbits; //Field offset: 0x34
	internal InflateBlocks blocks; //Field offset: 0x38

	internal bool HandleRfc1950HeaderBytes
	{
		internal get { } //Length: 5
		internal set { } //Length: 86
	}

	private static InflateManager() { }

	public InflateManager() { }

	public InflateManager(bool expectRfc1950HeaderBytes) { }

	internal int End() { }

	internal bool get_HandleRfc1950HeaderBytes() { }

	internal int Inflate(FlushType flush) { }

	internal int Initialize(ZlibCodec codec, int w) { }

	internal int Reset() { }

	internal void set_HandleRfc1950HeaderBytes(bool value) { }

	internal int SetDictionary(Byte[] dictionary) { }

	internal int Sync() { }

	internal int SyncPoint(ZlibCodec z) { }

}

