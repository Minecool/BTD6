namespace NinjaKiwi.LiNK.Client.DotNetZip.Zlib;

public class GZipStream : Stream
{
	internal static readonly DateTime _unixEpoch; //Field offset: 0x0
	internal static readonly Encoding iso8859dash1; //Field offset: 0x8
	public Nullable<DateTime> LastModified; //Field offset: 0x28
	private int _headerByteCount; //Field offset: 0x38
	internal ZlibBaseStream _baseStream; //Field offset: 0x40
	private bool _disposed; //Field offset: 0x48
	private bool _firstReadDone; //Field offset: 0x49
	private string _FileName; //Field offset: 0x50
	private string _Comment; //Field offset: 0x58
	private int _Crc32; //Field offset: 0x60

	public int BufferSize
	{
		 get { } //Length: 26
		 set { } //Length: 374
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

	public string Comment
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public int Crc32
	{
		 get { } //Length: 4
	}

	public string FileName
	{
		 get { } //Length: 5
		 set { } //Length: 423
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
		 get { } //Length: 87
		 set { } //Length: 62
	}

	public override long TotalIn
	{
		 get { } //Length: 36
	}

	public override long TotalOut
	{
		 get { } //Length: 36
	}

	private static GZipStream() { }

	public GZipStream(Stream stream, CompressionMode mode) { }

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level) { }

	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	public static Byte[] CompressBuffer(Byte[] b) { }

	public static Byte[] CompressString(string s) { }

	protected virtual void Dispose(bool disposing) { }

	private int EmitHeader() { }

	public virtual void Flush() { }

	public int get_BufferSize() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public string get_Comment() { }

	public int get_Crc32() { }

	public string get_FileName() { }

	public override FlushType get_FlushMode() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public override long get_TotalIn() { }

	public override long get_TotalOut() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public void set_BufferSize(int value) { }

	public void set_Comment(string value) { }

	public void set_FileName(string value) { }

	public override void set_FlushMode(FlushType value) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public static Byte[] UncompressBuffer(Byte[] compressed) { }

	public static string UncompressString(Byte[] compressed) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

