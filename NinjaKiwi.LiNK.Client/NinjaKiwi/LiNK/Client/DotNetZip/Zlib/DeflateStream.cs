namespace NinjaKiwi.LiNK.Client.DotNetZip.Zlib;

public class DeflateStream : Stream
{
	internal ZlibBaseStream _baseStream; //Field offset: 0x28
	internal Stream _innerStream; //Field offset: 0x30
	private bool _disposed; //Field offset: 0x38

	public int BufferSize
	{
		 get { } //Length: 26
		 set { } //Length: 358
	}

	public virtual bool CanRead
	{
		 get { } //Length: 139
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 139
	}

	public override FlushType FlushMode
	{
		 get { } //Length: 26
		 set { } //Length: 114
	}

	public virtual long Length
	{
		 get { } //Length: 62
	}

	public virtual long Position
	{
		 get { } //Length: 73
		 set { } //Length: 62
	}

	public CompressionStrategy Strategy
	{
		 get { } //Length: 26
		 set { } //Length: 114
	}

	public override long TotalIn
	{
		 get { } //Length: 36
	}

	public override long TotalOut
	{
		 get { } //Length: 36
	}

	public DeflateStream(Stream stream, CompressionMode mode) { }

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level) { }

	public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen, int windowBits) { }

	public static Byte[] CompressBuffer(Byte[] b) { }

	public static Byte[] CompressString(string s) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public int get_BufferSize() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public override FlushType get_FlushMode() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public CompressionStrategy get_Strategy() { }

	public override long get_TotalIn() { }

	public override long get_TotalOut() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public void set_BufferSize(int value) { }

	public override void set_FlushMode(FlushType value) { }

	public virtual void set_Position(long value) { }

	public void set_Strategy(CompressionStrategy value) { }

	public virtual void SetLength(long value) { }

	public static Byte[] UncompressBuffer(Byte[] compressed) { }

	public static string UncompressString(Byte[] compressed) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

