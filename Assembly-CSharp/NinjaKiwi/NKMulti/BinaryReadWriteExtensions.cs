namespace NinjaKiwi.NKMulti;

[Extension]
public static class BinaryReadWriteExtensions
{

	[Extension]
	public static List<Byte> ReadBitMask(BinaryReader reader) { }

	[Extension]
	public static List<Byte> ReadByteList(BinaryReader reader) { }

	[Extension]
	public static void WriteBitMask(BinaryWriter writer, List<Byte> bitsToSet) { }

	[Extension]
	public static void WriteByteList(BinaryWriter writer, List<Byte> byteList) { }

}

