namespace NinjaKiwi.NKMulti;

public class NKMultiMessage : Message, IDisposable
{
	public const string CODE = ""; //Field offset: 0x0
	public readonly MemoryStream Data; //Field offset: 0x20
	private readonly Writable Content; //Field offset: 0x28

	public NKMultiMessage(Byte[] data) { }

	public NKMultiMessage(Writable content) { }

	protected virtual Byte[] CreateBytes() { }

	public override void Dispose() { }

}

