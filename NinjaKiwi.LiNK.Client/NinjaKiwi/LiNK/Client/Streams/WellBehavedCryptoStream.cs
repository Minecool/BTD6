namespace NinjaKiwi.LiNK.Client.Streams;

public class WellBehavedCryptoStream : CryptoStream
{
	private readonly Stream _stream; //Field offset: 0x78
	private readonly bool _leaveOpen; //Field offset: 0x80
	private bool isDisposed; //Field offset: 0x81

	public WellBehavedCryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	public WellBehavedCryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	protected virtual void Dispose(bool disposing) { }

}

