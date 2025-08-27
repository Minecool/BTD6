namespace NinjaKiwi.LiNK.Client.Streams;

public class StringWriteStream : Stream
{
	public readonly StringBuilder output; //Field offset: 0x28
	private readonly MemoryStream outputBuffer; //Field offset: 0x30
	private readonly StreamReader outputReader; //Field offset: 0x38
	private readonly int bufferSize; //Field offset: 0x40
	private bool isDisposed; //Field offset: 0x44

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 8
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

	public StringWriteStream(Encoding stringEncoding, int bufferSize) { }

	[CompilerGenerated]
	private int <Write>g__capacityRemaining|6_0() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public StringBuilder GetResultAndClose() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

