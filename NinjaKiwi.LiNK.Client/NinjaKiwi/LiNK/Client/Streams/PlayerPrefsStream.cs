namespace NinjaKiwi.LiNK.Client.Streams;

internal abstract class PlayerPrefsStream : Stream
{

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual long Length
	{
		 get { } //Length: 62
	}

	protected PlayerPrefsStream() { }

	public static void Delete(string key) { }

	public static bool Exists(string key) { }

	public virtual bool get_CanSeek() { }

	public virtual long get_Length() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void SetLength(long value) { }

}

