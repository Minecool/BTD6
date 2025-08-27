namespace NinjaKiwi.LiNK.Client.DotNetZip.Zlib;

internal class ZlibBaseStream : Stream
{
	public enum StreamMode
	{
		Writer = 0,
		Reader = 1,
		Undefined = 2,
	}

	protected private ZlibCodec _z; //Field offset: 0x28
	protected private StreamMode _streamMode; //Field offset: 0x30
	protected private FlushType _flushMode; //Field offset: 0x34
	protected private ZlibStreamFlavor _flavor; //Field offset: 0x38
	protected private CompressionMode _compressionMode; //Field offset: 0x3C
	protected private CompressionLevel _level; //Field offset: 0x40
	protected private bool _leaveOpen; //Field offset: 0x44
	protected private Byte[] _workingBuffer; //Field offset: 0x48
	protected private int _bufferSize; //Field offset: 0x50
	protected private int windowBitsMax; //Field offset: 0x54
	protected private Byte[] _buf1; //Field offset: 0x58
	protected private Stream _stream; //Field offset: 0x60
	protected private CompressionStrategy Strategy; //Field offset: 0x68
	private CRC32 crc; //Field offset: 0x70
	protected private string _GzipFileName; //Field offset: 0x78
	protected private string _GzipComment; //Field offset: 0x80
	protected private DateTime _GzipMtime; //Field offset: 0x88
	protected private int _gzipHeaderByteCount; //Field offset: 0x90
	private bool nomoreinput; //Field offset: 0x94

	protected private bool _wantCompress
	{
		private get { } //Length: 8
	}

	public virtual bool CanRead
	{
		 get { } //Length: 42
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 42
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 42
	}

	internal int Crc32
	{
		internal get { } //Length: 16
	}

	public virtual long Length
	{
		 get { } //Length: 42
	}

	public virtual long Position
	{
		 get { } //Length: 62
		 set { } //Length: 62
	}

	private Byte[] workingBuffer
	{
		private get { } //Length: 73
	}

	private ZlibCodec z
	{
		private get { } //Length: 198
	}

	private int _ReadAndValidateGzipHeader() { }

	public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen, int windowBits) { }

	public virtual void Close() { }

	public static void CompressBuffer(Byte[] b, Stream compressor) { }

	public static void CompressString(string s, Stream compressor) { }

	private void end() { }

	private void finish() { }

	public virtual void Flush() { }

	protected private bool get__wantCompress() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	internal int get_Crc32() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	private Byte[] get_workingBuffer() { }

	private ZlibCodec get_z() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	private string ReadZeroTerminatedString() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public static Byte[] UncompressBuffer(Byte[] compressed, Stream decompressor) { }

	public static string UncompressString(Byte[] compressed, Stream decompressor) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

