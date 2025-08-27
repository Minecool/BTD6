namespace NinjaKiwi.NKMulti.Transfer;

public class Head
{
	public readonly byte Version; //Field offset: 0x10
	public readonly short MessageLength; //Field offset: 0x12

	public Head(byte version, short messageLength) { }

}

