namespace NinjaKiwi.LiNK.Client.Files;

[IsReadOnly]
internal struct StringAndVersion
{
	public readonly string value; //Field offset: 0x0
	public readonly int version; //Field offset: 0x8

	public StringAndVersion(string value, int version) { }

}

