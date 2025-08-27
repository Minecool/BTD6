namespace NinjaKiwi.LiNK.Client.Streams;

internal class PlayerPrefsWriteStream : PlayerPrefsStream
{
	private readonly string key; //Field offset: 0x28
	private readonly StringWriteStream stringStream; //Field offset: 0x30
	private readonly ToBase64Transform base64Transform; //Field offset: 0x38
	private readonly CryptoStream base64WriteStream; //Field offset: 0x40
	private bool isDisposed; //Field offset: 0x48

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 8
	}

	public virtual long Position
	{
		 get { } //Length: 62
		 set { } //Length: 62
	}

	public PlayerPrefsWriteStream(string key, int bufferSize) { }

	public void Delete() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual void set_Position(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

