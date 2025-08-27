namespace NinjaKiwi.LiNK.Client.Streams;

public class StringReadStream : Stream
{
	private readonly string inputString; //Field offset: 0x28
	private readonly Byte[] inputBuffer; //Field offset: 0x30
	private readonly Encoding encoding; //Field offset: 0x38
	private readonly MemoryStream inputStream; //Field offset: 0x40
	private bool isDisposed; //Field offset: 0x48
	private int inputCursor; //Field offset: 0x4C

	public virtual bool CanRead
	{
		 get { } //Length: 8
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public virtual long Length
	{
		 get { } //Length: 62
	}

	public virtual long Position
	{
		 get { } //Length: 62
		 set { } //Length: 62
	}

	public StringReadStream(string input, Encoding stringEncoding, int bufferSize) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	private bool Refill() { }

	internal void Reset() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

