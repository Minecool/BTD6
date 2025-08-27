namespace NinjaKiwi.LiNK.Transfer;

[IsReadOnly]
internal struct Request
{
	public readonly string url; //Field offset: 0x0
	public readonly Payload payload; //Field offset: 0x8

	internal Request(string url, Payload payload) { }

}

