namespace NinjaKiwi.LiNK.Client.DotNetZip.Zlib;

internal sealed class ZlibCodec
{
	public Byte[] InputBuffer; //Field offset: 0x10
	public int NextIn; //Field offset: 0x18
	public int AvailableBytesIn; //Field offset: 0x1C
	public long TotalBytesIn; //Field offset: 0x20
	public Byte[] OutputBuffer; //Field offset: 0x28
	public int NextOut; //Field offset: 0x30
	public int AvailableBytesOut; //Field offset: 0x34
	public long TotalBytesOut; //Field offset: 0x38
	public string Message; //Field offset: 0x40
	internal DeflateManager dstate; //Field offset: 0x48
	internal InflateManager istate; //Field offset: 0x50
	internal uint _Adler32; //Field offset: 0x58
	public CompressionLevel CompressLevel; //Field offset: 0x5C
	public int WindowBits; //Field offset: 0x60
	public CompressionStrategy Strategy; //Field offset: 0x64

	public int Adler32
	{
		 get { } //Length: 4
	}

	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	public ZlibCodec() { }

	public ZlibCodec(CompressionMode mode) { }

	public int Deflate(FlushType flush) { }

	public int EndDeflate() { }

	public int EndInflate() { }

	internal void flush_pending() { }

	public int get_Adler32() { }

	public int Inflate(FlushType flush) { }

	public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header) { }

	public int InitializeDeflate(CompressionLevel level, int bits) { }

	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	public int InitializeDeflate(CompressionLevel level) { }

	public int InitializeDeflate() { }

	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	public int InitializeInflate(int windowBits) { }

	public int InitializeInflate(bool expectRfc1950Header) { }

	public int InitializeInflate() { }

	internal int read_buf(Byte[] buf, int start, int size) { }

	public void ResetDeflate() { }

	public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy) { }

	public int SetDictionary(Byte[] dictionary) { }

	public int SyncInflate() { }

}

