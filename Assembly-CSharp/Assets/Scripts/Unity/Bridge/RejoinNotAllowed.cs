namespace Assets.Scripts.Unity.Bridge;

public class RejoinNotAllowed : IBtd6MessageType
{
	public byte playerNumber; //Field offset: 0x10

	public RejoinNotAllowed(byte playerNumber) { }

	public static RejoinNotAllowed Decode(BinaryReader reader) { }

	public static void Encode(BinaryWriter writer, RejoinNotAllowed dts) { }

}

