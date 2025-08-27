namespace NinjaKiwi.LiNK.Client.Streams;

internal class PlayerPrefsReadStream : PlayerPrefsStream
{
	private readonly StringReadStream stringStream; //Field offset: 0x28
	private FromBase64Transform base64Transform; //Field offset: 0x30
	private WellBehavedCryptoStream base64ReadStream; //Field offset: 0x38
	private long position; //Field offset: 0x40
	private bool isDisposed; //Field offset: 0x48

	public virtual bool CanRead
	{
		 get { } //Length: 8
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public virtual long Position
	{
		 get { } //Length: 5
		 set { } //Length: 473
	}

	public PlayerPrefsReadStream(string key, int bufferSize) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual void set_Position(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

