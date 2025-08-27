namespace Assets.Scripts.Unity.Bridge;

[Extension]
public static class BinaryEncoderExtensions
{

	[Extension]
	public static uint ReadUint32As3Bytes(BinaryReader reader) { }

	[Extension]
	public static void WriteUInt32As3Bytes(BinaryWriter writer, uint value) { }

}

