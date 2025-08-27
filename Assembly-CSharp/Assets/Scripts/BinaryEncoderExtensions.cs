namespace Assets.Scripts;

[Extension]
public static class BinaryEncoderExtensions
{

	[Extension]
	public static ObjectId ReadObjectId(BinaryReader reader) { }

	[Extension]
	public static void Write(BinaryWriter writer, ObjectId objectId) { }

}

